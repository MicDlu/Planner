using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Plan
    {
        public Shift[,,] Shifts { get; set; }
        public String[] ProductionLines { get; set; }
        public DateTime[] Week { get; set; }
        private ExcelInterop Excel;
        public List<Worker> Workers { get; set; }
        Random random = new Random();

        public Plan(string filename, DateTime monday)
        {
            ProductionLines = InitProductionLines(true);
            Week = InitWeek(monday);
            Excel = new ExcelInterop(filename);
            //LoadWorkersFromFile();
            GenerateRandomWorkers(100);
        }

        public void ExtractOrderAmountsFromRange(string cellBegin, string cellEnd = null)
        {
            Excel.SetWeekCellRange(cellBegin,cellEnd);
            int[,] rawOrder = Excel.ExtractRangeValues();

            Shifts = new Shift[Const.ProductionLinesCount, Const.GridRowsCount, 2];
            for (int p = 0; p < Const.ProductionLinesCount; p++)
            {
                for (int d = 0; d < Const.WorkDays; d++)
                {
                    for (int s = 0; s < Const.ShiftsPerDay; s++)
                    {
                        int rawRow = p * 7 + s * 2;
                        int rawCol = d * 3;
                        Shifts[p, Const.ShiftsPerDay * d + s, 0] = new Shift(d, s, p, Const.Sex.Male, rawOrder[rawRow + 1, rawCol]);
                        Shifts[p, Const.ShiftsPerDay * d + s, 1] = new Shift(d, s, p, Const.Sex.Female, rawOrder[rawRow, rawCol]);
                    }
                }
            }
        }

        public void CloseExcel(bool save)
        {
            Excel.Close(save);
        }
        public void KillExcel()
        {
            Excel.KillAllExcelProcesses();
        }


        public void SaveWorkersToFile()
        {
            Excel.SaveWorkers(Workers);
        }

        public void LoadWorkersFromFile()
        {
            Workers = Excel.LoadWorkers();
        }

        private string[] InitProductionLines(bool open)
        {
            if (open)
                return Const.ProductionLines;
            String[] newProductionLines = new string[Const.ProductionLinesCount];
            for (int i = 0; i < Const.ProductionLinesCount; i++)
            {
                newProductionLines[i] = "Production Line " + (i+1).ToString();
            }
            return newProductionLines;
        }

        private DateTime[] InitWeek(DateTime monday)
        {
            DateTime[] newWeek = new DateTime[Const.WorkDays];
            newWeek[0] = monday;
            for (int i = 1; i < Const.WorkDays; i++)
            {
                newWeek[i] = newWeek[0].AddDays(i);
            }
            Values.Week = newWeek;
            return newWeek;
        }

        public void GenerateRandomWorkers(int count)
        {
            DateTime prevWeekSunday = Week[0].Subtract(new TimeSpan(1, 0, 0, 0));
            string[] lastnames = { "Mazur", "Górski", "Potok", "Podgórski", "Borkowski", "Stawecki", "Krajewski", "Czech", "Szymański", "Jankowski", "Wojciechowski", "Piotrowski", "Pawłowski", "Jakubowski", "Kowalski", "Woźniak", "Krawczyk", "Szewczyk", "Swat", "Kaczmarek", "Wdowiak", "Cichocki", "Wysocki", "Czarnecki", "Wesołowski", "Małecki", "Kędzierski", "Dobrucki", "Cieślak "};
            List<string>[] names = new List<string>[2];
            names[0] = new List<string>() { "Stanisław", "Andrzej", "Józef", "Tadeusz", "Jerzy", "Zbigniew", "Krzysztof", "Henryk", "Ryszard", "Kazimierz", "Marek", "Marian", "Piotr", "Janusz", "Władysław", "Adam", "Wiesław", "Zdzisław", "Edward", "Mieczysław", "Roman", "Mirosław", "Grzegorz", "Czesław", "Dariusz", "Wojciech", "Jacek", "Eugeniusz", "Tomasz"};
            names[1] = new List<string>() { "Krystyna", "Anna", "Barbara", "Teresa", "Elżbieta", "Janina", "Zofia", "Jadwiga", "Danuta", "Halina", "Irena", "Ewa", "Małgorzata", "Helena", "Grażyna", "Bożena", "Stanisława", "Jolanta", "Marianna", "Urszula", "Wanda", "Alicja", "Dorota", "Agnieszka", "Beata", "Katarzyna", "Joanna", "Wiesława", "Renata" };

            Workers = new List<Worker>();
            
            for (int i = 0; i < count; i++)
            {
                Worker.DateBool dbFrom;
                Worker.DateShift dsLast;
                int gender = random.Next(2);
                Worker worker = new Worker(
                    i+1,
                    names[gender].ElementAt(random.Next(names[gender].Count)),
                    lastnames[random.Next(lastnames.Length)],
                    (Const.Sex)gender,
                    random.Next(-3, 3),
                    dbFrom = new Worker.DateBool() { active = (random.Next(2) == 1), date = new DateTime(random.Next(2018, 2020), random.Next(1, 13), random.Next(1, 29)) },
                    new Worker.DateBool() { active = (random.Next(2) == 1), date = dbFrom.date.Add(new TimeSpan(random.Next(365),0,0,0)) },
                    dsLast = new Worker.DateShift() { shift = random.Next(1, 4), date = prevWeekSunday.Subtract(new TimeSpan(random.Next(15),0,0,0)) },
                    dsLast.date==prevWeekSunday?prevWeekSunday.Subtract(new TimeSpan(random.Next(1,10), 0, 0, 0)):prevWeekSunday,
                    dsLast.date==prevWeekSunday?prevWeekSunday.Subtract(new TimeSpan(random.Next(1,7)*7,0,0,0)): prevWeekSunday,
                    RandomDayPick(true),
                    RandomDayPick(false),
                    RandomProductionPick()
                );                                                           
                Workers.Add(worker);
            }
        }

        private bool[,] RandomDayPick(bool allowNull)
        {
            if (allowNull && (random.Next(2) == 1))
                return null;
            bool[,] pick = new bool[Const.WorkDays, Const.ShiftsPerDay];
            for (int i = 0; i < pick.GetLength(0); i++)
            {
                for (int j = 0; j < pick.GetLength(1); j++)
                {
                    pick[i, j] = random.Next(2) == 1;
                }
            }
            return pick;
        }

        private bool[] RandomProductionPick()
        {
            bool[] pick = new bool[Const.ProductionLinesCount];
            for (int i = 0; i < pick.GetLength(0); i++)
            {
                pick[i] = random.Next(10)/2 > 0;
            }
            return pick;
        }
    }
}
