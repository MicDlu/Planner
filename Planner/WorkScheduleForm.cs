﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class WorkScheduleForm : Form
    {
        private Plan plan;

        public WorkScheduleForm()
        {
            InitializeComponent();
            plan = new Plan();
            
            plan.Shifts[2, 2].EmployeeAssigned.Add(new Employee(1, "Maciej", "Bojar"));
            plan.Shifts[2, 2].EmployeeAssigned.Add(new Employee(2, "Kamil", "Pieczara"));
        }

        private void WorkScheduleForm_Load(object sender, EventArgs e)
        {           
            InitDataGridViewValues(plan);
            InitDataGridViewStyle();
            InitListBoxStyle();
            InitGroupBoxAssignedStyle();
            AlignFormSize();
        }

        private void InitGroupBoxAssignedStyle()
        {
            groupBoxEmployees.Location = new Point(
                dataGridView1.Location.X + dataGridView1.Size.Width + 30,
                dataGridView1.Location.Y
            );
        }

        private void AlignFormSize()
        {
            this.Size = new Size(
                groupBoxEmployees.Location.X + groupBoxEmployees.Size.Width + 30,
                dataGridView1.Location.Y + dataGridView1.Size.Height + 50
            ); 
        }

        private void InitListBoxStyle()
        {
            listBoxEmpolyees.DisplayMember = "DisplayName";
            listBoxEmpolyees.ValueMember = "Id";
        }

        // Draw DataGridView Headers
        // https://stackoverflow.com/questions/41891108/merge-mulitple-row-headers-in-a-datagridview-with-c-sharp
        private void InitDataGridViewStyle()
        {
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.RowHeadersWidth = 80;
            dataGridView1.RowHeadersWidth = dataGridView1.RowHeadersWidth * 3 / 2;
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.RowHeadersWidthChanged += dataGridView1_RowHeadersWidthChanged;
            dataGridView1.Paint += dataGridView1_Paint;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                column.Width = 75;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            SizeDGV(dataGridView1);
            this.AutoSize = true;
        }

        // Fill cells and headers with values
        // https://stackoverflow.com/questions/29633018/show-2d-array-in-datagridview
        private void InitDataGridViewValues(Plan plan)
        {
            int columnCount = plan.ProductionLines.Length;
            int rowCount = plan.Shifts.GetLength(1);

            // Columns - Production Lines
            for (int i = 0; i < plan.ProductionLines.Length; i++)
            {
                DataGridViewTextBoxColumn dgvColumn = new DataGridViewTextBoxColumn()
                {
                    Name = plan.ProductionLines[i],
                    HeaderText = plan.ProductionLines[i],
                };
                dataGridView1.Columns.Add(dgvColumn);
            }
            // Rows - Days / Shifts
            for (int rd = 0; rd < rowCount / Constants.ShiftsPerDay; rd++)
            {
                for (int rh = 0; rh < Constants.ShiftsPerDay; rh++)
                {
                    int r = Constants.ShiftsPerDay * rd + rh;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.HeaderCell.Value = (rh + 1).ToString();
                    dataGridView1.Rows.Add(row);
                }
            }
            UpdateAssignedValues();
        }

        private void UpdateAssignedValues()
        {
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    string assigned = plan.Shifts[c, r].EmployeeAssigned.Count.ToString();
                    string ordered = plan.Shifts[c, r].Order.ToString();
                    dataGridView1[c, r].Value = assigned + "/" + ordered;
                }
            }
        }
        
        // Draw DataGridView Headers
        private void InvalidateHeader()
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Width = this.dataGridView1.RowHeadersWidth / 2;
            dataGridView1.Invalidate(rtHeader);
        }

        // Draw DataGridView Headers
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            int row = 0;

            foreach (DateTime day in plan.Week)
            {
                Rectangle dayRect = dataGridView1.GetCellDisplayRectangle(-1, row, true);
                dayRect.X =  1;
                dayRect.Y = row * dayRect.Height + dataGridView1.ColumnHeadersHeight;
                dayRect.Height = dayRect.Height * Constants.ShiftsPerDay - 2;
                dayRect.Width = dayRect.Width * 2 / 3 - 2;

                using (Brush back = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.BackColor))
                using (Brush fore = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
                using (Pen p = new Pen(dataGridView1.GridColor))
                using (StringFormat format = new StringFormat())
                {
                    string dayText = day.DayOfWeek.ToString();
                    dayText += Environment.NewLine + day.ToShortDateString();

                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    e.Graphics.FillRectangle(back, dayRect);
                    e.Graphics.DrawRectangle(p, dayRect);
                    e.Graphics.DrawString(dayText, dataGridView1.RowHeadersDefaultCellStyle.Font, fore, dayRect, format);
                }
                row += Constants.ShiftsPerDay;
            }
        }

        // Draw DataGridView Headers
        // https://stackoverflow.com/questions/37661303/how-to-fit-datagridview-width-and-height-to-its-content
        void SizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += 1; ;  // a correction I need
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }

        // Draw DataGridView Headers
        private void dataGridView1_RowHeadersWidthChanged(object sender, EventArgs e)
        {
            InvalidateHeader();
            SizeDGV(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                listBoxEmpolyees.DataSource = plan.Shifts[e.ColumnIndex, e.RowIndex].EmployeeAssigned;
                listBoxEmpolyees.DisplayMember = "DisplayName";
                listBoxEmpolyees.ValueMember = "Id";
            }
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            int selectedCellX = dataGridView1.CurrentCell.RowIndex;
            int selectedCellY = dataGridView1.CurrentCell.ColumnIndex;
            List<Employee> employeeList = plan.Shifts[selectedCellX, selectedCellY].EmployeeAssigned;
            if (employeeList.Count != 0)
            {
                employeeList.RemoveAt(listBoxEmpolyees.SelectedIndex);

                listBoxEmpolyees.DataSource = null;
                listBoxEmpolyees.DataSource = plan.Shifts[selectedCellX, selectedCellY].EmployeeAssigned;
                listBoxEmpolyees.DisplayMember = "DisplayName";
                listBoxEmpolyees.ValueMember = "Id";
                UpdateAssignedValues();
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\micha\Documents\Planer Manpower\PLANER 2018 t.38.xlsm";
            ExcelInterop excel = new ExcelInterop(filename);
            excel.SetWeekCellRange("E6");
            excel.ProcessOrder();
        }
    }
}
