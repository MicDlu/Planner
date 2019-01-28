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
    public partial class ProductionsPickForm : Form
    {
        public bool[] Matrix { get; set; }

        public ProductionsPickForm()
        {
            InitializeComponent();
        }

        private void ProductionsPickForm_Load(object sender, EventArgs e)
        {
            initDGVValues();
        }

        private void initDGVValues()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());

            for (int p = 0; p < Const.ProductionLinesCount; p++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = Matrix[p];
                row.HeaderCell.Value = Const.ProductionLines[p];
                dataGridView1.Rows.Add(row);
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Matrix = new bool[dataGridView1.RowCount];
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                if (dataGridView1[0,r].Value != null)
                    Matrix[r] = (bool)dataGridView1[0, r].Value;
                else
                    Matrix[r] = false;
            }
        }
    }
}
