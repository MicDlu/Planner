using System;
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
    public partial class DayDispositionForm : Form
    {
        public bool[,] Matrix { get; set; }

        public DayDispositionForm()
        {
            InitializeComponent();
        }

        private void DayDispositionForm_Load(object sender, EventArgs e)
        {
            InitDGVValues();
        }

        private void InitDGVValues()
        {
            dataGridView1.Columns.Clear();
            for (int d = 0; d < Const.WorkDays; d++)
            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn()
                {
                    Name = Values.Week[d].DayOfWeek.ToString(),
                    HeaderText = Const.Days[d],
                    Width = 50
                };
                dataGridView1.Columns.Add(col);
            }

            for (int s = 0; s < Const.ShiftsPerDay; s++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.HeaderCell.Value = (s + 1).ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Matrix = new bool[dataGridView1.ColumnCount, dataGridView1.RowCount];
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    if ((dataGridView1[c, r].Value) == null)
                        Matrix[c, r] = false;
                    else
                        Matrix[c, r] = true;
                }
            }
        }
    }
}
