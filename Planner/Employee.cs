using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Const.Sex Sex { get; set; }
        public string DisplayName { get; set; }
        public DateBool AvailableFrom { get; set; }
        public DateBool AvailableTo { get; set; }
        public int Priority { get; set; }
        public DateShift LastShift { get; set; }
        public DateTime LastFreeDay { get; set; }
        public DateTime LastFreeSunday { get; set; }
        public bool[,] WeekDisposition { get; set; }
        public bool[,] FixedPerDay { get; set; }
        public bool[] ProductionsCheck { get; set; }


        public Worker(int id, string name, string lastname, Const.Sex sex)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            DisplayName = name + " " + lastname;
            Sex = sex;

            //AvailableFrom = new DateBool() { date = new DateTime(), active = false };
            //AvailableTo = new DateBool() { date = new DateTime(), active = false };           
            //Priority = Const.MaxPriority/2;
            //LastShift = new DateShift() { date = new DateTime(), shift = 0 };
            //LastFreeDay = new DateTime();
            //LastFreeSunday = new DateTime();
            WeekDisposition = new bool[Const.WorkDays, Const.ShiftsPerDay];
            FixedPerDay = new bool[Const.WorkDays, Const.ShiftsPerDay];
            ProductionsCheck = new bool[Const.ProductionLinesCount];
        }

        public Worker(List<string> fromExcel)
        {
            Id = int.Parse(fromExcel[Const.excelFields.ID]);
            Name = fromExcel[Const.excelFields.NAME];
            Lastname = fromExcel[Const.excelFields.LASTNAME];
            DisplayName = Name + " " + Lastname;
            Sex = fromExcel[Const.excelFields.GENDER] =="M"?Const.Sex.Male:Const.Sex.Female;
            Priority = int.Parse(fromExcel[Const.excelFields.PRIORITY]);
            if (fromExcel[Const.excelFields.FROM] == string.Empty)
                AvailableFrom = new DateBool() { active = false };
            else
                AvailableFrom = new DateBool() { active = true, date=DateTime.ParseExact(fromExcel[Const.excelFields.FROM],Const.systemUIDateFormat,null)};
            if (fromExcel[Const.excelFields.TO] == string.Empty)
                AvailableTo = new DateBool() { active = false };
            else
                AvailableTo = new DateBool() { active = true, date = DateTime.ParseExact(fromExcel[Const.excelFields.TO], Const.systemUIDateFormat, null) };

            //AvailableTo = new DateBool()
            //{
            //    active = fromExcel[Const.excelFields.TO] != string.Empty,
            //date = fromExcel[Const.excelFields.TO] == string.Empty ? new DateTime() : DateTime.ParseExact(fromExcel[Const.excelFields.TO], Const.systemUIDateFormat, null)
            //};

            LastShift = new DateShift()
            {
                date = DateTime.ParseExact(fromExcel[Const.excelFields.LASTSHIFT].Substring(0, 10), Const.systemUIDateFormat, null),
                shift = int.Parse(fromExcel[Const.excelFields.LASTSHIFT].Substring(11, 1))
            };

            LastFreeDay = fromExcel[Const.excelFields.LASTFREEDAY] == string.Empty ? new DateTime() : DateTime.ParseExact(fromExcel[Const.excelFields.LASTFREEDAY], Const.systemUIDateFormat, null);
            LastFreeSunday = fromExcel[Const.excelFields.LASTFREESUNDAY] == string.Empty ? new DateTime() : DateTime.ParseExact(fromExcel[Const.excelFields.LASTFREESUNDAY], Const.systemUIDateFormat, null);

            WeekDisposition = DaysCheckFromText(fromExcel[Const.excelFields.THISWEEK]);
            FixedPerDay = DaysCheckFromText(fromExcel[Const.excelFields.FIXEDWEEK]);
            ProductionsCheck = ProductionCheckFromText(fromExcel[Const.excelFields.FIXEDPRODUCTION]);
        }

        public List<string> ToExcelFormat()
        {
            return new List<string>
            {
                Id.ToString(),
                Name,
                Lastname,
                Sex==Const.Sex.Male?"M":"K",
                Priority.ToString(),
                AvailableFrom.ToString(),
                AvailableTo.ToString(),
                LastShift.ToString(),
                LastFreeDay.ToString(Const.systemUIDateFormat),
                LastFreeSunday.ToString(Const.systemUIDateFormat),
                DaysCheckToText(WeekDisposition),
                DaysCheckToText(FixedPerDay),
                ProductionsCheckToText(ProductionsCheck)
            };
        }

        public string DaysCheckToText(bool[,] disposition)
        {
            if (disposition == null)
                return string.Empty;
            string result = string.Empty;
            for (int r = 0; r < disposition.GetLength(0); r++)
            {
                for (int c = 0; c < disposition.GetLength(1); c++)
                {
                    result += disposition[r, c] ? "1" : "0";
                    if (c+1 < disposition.GetLength(1))
                        result += ",";
                }
                if (r+1 < disposition.GetLength(0))
                    result += ";";
            }
            return result;
        }

        public bool[,] DaysCheckFromText(string text)
        {
            if (text == string.Empty)
                return null;
            bool[,] result = new bool[Const.WorkDays, Const.ShiftsPerDay];
            for (int r = 0; r < Const.WorkDays; r++)
            {
                for (int c = 0; c < Const.ShiftsPerDay; c++)
                {
                    result[r, c] = text[6 * r + 2*c] == '1' ? true : false;
                }
            }
            return result;
        }

        public string ProductionsCheckToText(bool[] check)
        {
            if (check == null)
                return string.Empty;
            string result = string.Empty;
            for (int r = 0; r < check.GetLength(0); r++)
            {
                result += check[r] ? "1" : "0";
                if (r < check.GetLength(0))
                    result += ";";
            }
            return result;
        }

        public bool[] ProductionCheckFromText(string text)
        {
            if (text == string.Empty)
                return null;
            bool[] result = new bool[Const.ProductionLinesCount];
            for (int p = 0; p < Const.ProductionLinesCount; p++)
            {
                result[p] = text[2 * p] == '1' ? true : false;
            }
            return result;
        }


        public struct DateShift
        {
            public DateTime date;
            public int shift;

            public override string ToString()
            {
                return date.ToString(Const.systemUIDateFormat) + "-" + shift.ToString();
            }
        }

        public struct DateBool
        {
            public DateTime date;
            public bool active;

            public override string ToString()
            {
                //return date.ToString(Const.systemUIDateFormat) + "-" + (active?"1":"0");
                return (active ? date.ToString(Const.systemUIDateFormat) : string.Empty);
            }
        }
    }
}
