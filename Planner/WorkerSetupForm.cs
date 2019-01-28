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
    public partial class WorkerSetupForm : Form
    {
        public List<Worker> Workers { get; set; }
        public Worker WorkerSelected { get; set; }

        public WorkerSetupForm()
        {
            InitializeComponent();
            InitTestWorkers();
        }

        private void InitTestWorkers()
        {
            int idx = 1;
            Workers = new List<Worker>();
            Workers.Add(new Worker(idx++, "Pracownik", "Testowy" + idx.ToString(), Const.Sex.Male));
            Workers.Add(new Worker(idx++, "Pracownik", "Testowy" + idx.ToString(), Const.Sex.Male));
            Workers.Add(new Worker(idx++, "Pracownik", "Testowy" + idx.ToString(), Const.Sex.Male));
            Workers.Add(new Worker(idx++, "Pracownik", "Testowy" + idx.ToString(), Const.Sex.Male));
            Workers.Add(new Worker(idx++, "Pracownica", "Testowa" + idx.ToString(), Const.Sex.Female));
            Workers.Add(new Worker(idx++, "Pracownica", "Testowa" + idx.ToString(), Const.Sex.Female));
            Workers.Add(new Worker(idx++, "Pracownica", "Testowa" + idx.ToString(), Const.Sex.Female));
            Workers.Add(new Worker(idx++, "Pracownica", "Testowa" + idx.ToString(), Const.Sex.Female));
        }

        private void WorkerSetupForm_Load(object sender, EventArgs e)
        {
            InitDGVHeaders();
            FillDGVRows();
            PopulateWorkerData();
        }

        private void PopulateWorkerData()
        {
            tbID.Text = WorkerSelected.Id.ToString();
            tbName.Text = WorkerSelected.Name;
            tbLastname.Text = WorkerSelected.Lastname;
            cbSex.SelectedIndex = (int)WorkerSelected.Sex;

            if (WorkerSelected.AvailableFrom == new DateTime())
                dtpActualFrom.Checked = false;
            else
                dtpActualFrom.Value = WorkerSelected.AvailableFrom;

            if (WorkerSelected.AvailableTo == new DateTime())
                dtpActualTo.Checked = false;
            else
                dtpActualTo.Value = WorkerSelected.AvailableTo;

            tbActualPriority.Text = WorkerSelected.Priority.ToString();
        }

        private void InitDGVHeaders()
        {
            dgvWorkers.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { Name = "ID", HeaderText = "ID" });
            dgvWorkers.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { Name = "Name", HeaderText = "Imię" });
            dgvWorkers.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { Name = "Lastname", HeaderText = "Nazwisko" });
            dgvWorkers.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()) { Name = "Sex", HeaderText = "Płeć" });
        }

        private void FillDGVRows()
        {
            dgvWorkers.Rows.Clear();
            foreach (var worker in Workers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvWorkers);
                row.Cells[0].Value = worker.Id.ToString();
                row.Cells[1].Value = worker.Name;
                row.Cells[2].Value = worker.Lastname;
                row.Cells[3].Value = (worker.Sex == Const.Sex.Male)?("♂ Mężczyzna") :("♀ Kobieta");
                dgvWorkers.Rows.Add(row);
            }
        }

        private void dgvWorkers_SelectionChanged(object sender, EventArgs e)
        {
            WorkerSelected = Workers[dgvWorkers.CurrentCell.RowIndex];
            PopulateWorkerData();
        }

        private void bActualWeekAvailability_Click(object sender, EventArgs e)
        {
            DayDispositionForm dayDispositionForm = new DayDispositionForm();
            dayDispositionForm.Matrix = WorkerSelected.WeekDisposition;
            var result = dayDispositionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                WorkerSelected.WeekDisposition = dayDispositionForm.Matrix;
                tbActualWeekAvailability.Text = WorkerSelected.DispositionToText(WorkerSelected.WeekDisposition);
            }
        }

        private void bFixedDay_Click(object sender, EventArgs e)
        {
            DayDispositionForm dayDispositionForm = new DayDispositionForm();
            dayDispositionForm.Matrix = WorkerSelected.FixedPerDay;
            var result = dayDispositionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                WorkerSelected.FixedPerDay = dayDispositionForm.Matrix;
                tbFixedDay.Text = WorkerSelected.DispositionToText(WorkerSelected.FixedPerDay);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            WorkerSelected.Name = tbName.Text;
        }

        private void tbLastname_TextChanged(object sender, EventArgs e)
        {
            WorkerSelected.Lastname = tbLastname.Text;
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkerSelected.Sex = (Const.Sex)cbSex.SelectedIndex;
        }

        private void dtpActualFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpActualFrom.Checked)
                WorkerSelected.AvailableFrom = dtpActualFrom.Value;
            else
                WorkerSelected.AvailableFrom = new DateTime();
        }

        private void dtpActualTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpActualTo.Checked)
                WorkerSelected.AvailableTo = dtpActualTo.Value;
            else
                WorkerSelected.AvailableTo = new DateTime();
        }
    }
}
