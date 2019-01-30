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
        public Worker CurrWorker { get; set; }
        private bool[,] WeekDisposition { get; set; }
        private bool[,] FixedDisposition { get; set; }
        private bool[] ProductionsCheck { get; set; }

        public WorkerSetupForm()
        {
            InitializeComponent();
        }

        private void WorkerSetupForm_Load(object sender, EventArgs e)
        {
            InitDGVHeaders();
            InitPriorityItems();
            InitShiftItems();
            FillDGVRows();
        }

        private void InitShiftItems()
        {
            cbLastShift.Items.Clear();
            cbLastShift.Items.Add(new ComboBoxItem() { Name = "", Value = 0 });
            for (int i = 1; i <= Const.ShiftsPerDay; i++)
            {
                cbLastShift.Items.Add(new ComboBoxItem() { Name = i.ToString(), Value = i });
            }
        }

        private void InitPriorityItems()
        {
            cbPriority.Items.Clear();
            for (int i = -Const.PriorityRange; i <= Const.PriorityRange; i++)
            {
                cbPriority.Items.Add(new ComboBoxItem() { Name = i.ToString(), Value = i });
            }
        }

        private void PopulateWorkerData()
        {
            tbID.Text = CurrWorker.Id.ToString();
            tbName.Text = CurrWorker.Name;
            tbLastname.Text = CurrWorker.Lastname;
            cbSex.SelectedIndex = (int)CurrWorker.Sex;
            cbPriority.SelectedIndex = cbPriority.FindStringExact(CurrWorker.Priority.ToString());
            WeekDisposition = CurrWorker.WeekDisposition;
            chbWeekAvailability.Checked = CurrWorker.WeekDisposition != null;
            tbActualWeekAvailability.Text = CurrWorker.DaysCheckToText(WeekDisposition);
            FixedDisposition = CurrWorker.FixedPerDay;
            tbFixedDay.Text = CurrWorker.DaysCheckToText(FixedDisposition);
            ProductionsCheck = CurrWorker.ProductionsCheck;
            tbFixedProduction.Text = CurrWorker.ProductionsCheckToText(ProductionsCheck);
            // From
            if (CurrWorker.AvailableFrom.date <= dtpActualFrom.MaxDate && CurrWorker.AvailableFrom.date >= dtpActualFrom.MinDate)
                dtpActualFrom.Value = CurrWorker.AvailableFrom.date;
            else
                dtpActualFrom.Value = DateTime.Today;
            dtpActualFrom.Checked = CurrWorker.AvailableFrom.active;
            // To
            if (CurrWorker.AvailableTo.date <= dtpActualTo.MaxDate && CurrWorker.AvailableTo.date >= dtpActualTo.MinDate)
                dtpActualTo.Value = CurrWorker.AvailableTo.date;
            else
                dtpActualTo.Value = DateTime.Today;
            dtpActualTo.Checked = CurrWorker.AvailableTo.active;
            // Free day
            if (CurrWorker.LastFreeDay <= dtpActualLastFreeDay.MaxDate && CurrWorker.LastFreeDay >= dtpActualLastFreeDay.MinDate)
                dtpActualLastFreeDay.Value = CurrWorker.LastFreeDay;
            else
                dtpActualLastFreeDay.Value = dtpActualLastFreeDay.MinDate;
            // Free sunday
            if (CurrWorker.LastFreeSunday <= dtpActualLastFreeSunday.MaxDate && CurrWorker.LastFreeSunday >= dtpActualLastFreeSunday.MinDate)
                dtpActualLastFreeSunday.Value = CurrWorker.LastFreeSunday;
            else
                dtpActualLastFreeSunday.Value = dtpActualLastFreeSunday.MinDate;
            // Last shift
            if (CurrWorker.LastShift.date <= dtpLastShift.MaxDate && CurrWorker.LastShift.date >= dtpLastShift.MinDate)
                dtpLastShift.Value = CurrWorker.LastShift.date;
            else
                dtpLastShift.Value = dtpActualLastFreeSunday.MinDate;

            cbLastShift.SelectedIndex = CurrWorker.LastShift.shift;
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
            foreach (var worker in Values.plan.Workers)
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
            if (dgvWorkers.CurrentCell.RowIndex >= Values.plan.Workers.Count)
                CurrWorker = Values.plan.Workers[dgvWorkers.CurrentCell.RowIndex-1];
            else
                CurrWorker = Values.plan.Workers[dgvWorkers.CurrentCell.RowIndex];
            PopulateWorkerData();
        }

        private void bActualWeekAvailability_Click(object sender, EventArgs e)
        {
            DaysPickForm DaysPickForm = new DaysPickForm
            {
                Matrix = WeekDisposition
            };
            var result = DaysPickForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                WeekDisposition = DaysPickForm.Matrix;
                tbActualWeekAvailability.Text = CurrWorker.DaysCheckToText(WeekDisposition);
            }
        }

        private void bFixedDay_Click(object sender, EventArgs e)
        {
            DaysPickForm daysPickForm = new DaysPickForm
            {
                Matrix = FixedDisposition
            };
            var result = daysPickForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                FixedDisposition = daysPickForm.Matrix;
                tbFixedDay.Text = CurrWorker.DaysCheckToText(FixedDisposition);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            CurrWorker.Name = tbName.Text;
            CurrWorker.Lastname = tbLastname.Text;
            CurrWorker.Sex = (Const.Sex)cbSex.SelectedIndex;
            CurrWorker.Priority = ((ComboBoxItem)cbPriority.SelectedItem).Value;
            CurrWorker.WeekDisposition = WeekDisposition;
            CurrWorker.FixedPerDay = FixedDisposition;
            CurrWorker.AvailableFrom = new Worker.DateBool() { active = dtpActualFrom.Checked, date = dtpActualFrom.Value };
            CurrWorker.AvailableTo = new Worker.DateBool() { active = dtpActualTo.Checked, date = dtpActualTo.Value };
            CurrWorker.LastFreeDay = dtpActualLastFreeDay.Value;
            CurrWorker.LastFreeSunday = dtpActualLastFreeSunday.Value;
            CurrWorker.LastShift = new Worker.DateShift() { date = dtpLastShift.Value, shift = ((ComboBoxItem)cbLastShift.SelectedItem).Value };

        }

        private void bFixedProduction_Click(object sender, EventArgs e)
        {
            ProductionsPickForm productionsPickForm = new ProductionsPickForm
            {
                Matrix = ProductionsCheck
            };
            var result = productionsPickForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                ProductionsCheck = productionsPickForm.Matrix;
                tbFixedProduction.Text = CurrWorker.ProductionsCheckToText(ProductionsCheck);
            }
        }

        private void chbWeekAvailability_CheckedChanged(object sender, EventArgs e)
        {
            bActualWeekAvailability.Enabled = chbWeekAvailability.Checked;
            tbActualWeekAvailability.Enabled = chbWeekAvailability.Checked;
            if (chbWeekAvailability.Checked)
                WeekDisposition = new bool[Const.WorkDays, Const.ShiftsPerDay];
            else
                WeekDisposition = null;
        }

        private void zapiszDoPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Values.plan.Workers = Values.plan.Workers;
            using (ProcessingForm processingForm = new ProcessingForm(Values.plan.SaveWorkersToFile))
            {
                processingForm.ShowDialog();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Values.plan.Workers.Add(new Worker(Values.plan.Workers.Count + 1, "", "", Const.Sex.Male));
            FillDGVRows();
            dgvWorkers.CurrentCell = dgvWorkers.Rows[Values.plan.Workers.Count - 1].Cells[0];
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            Values.plan.Workers.RemoveAt(Values.plan.Workers.FindIndex(x => x.Id == CurrWorker.Id));
            FillDGVRows();
        }
    }
}
