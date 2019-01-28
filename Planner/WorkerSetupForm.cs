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
        }

        private void bActualWeekAvailability_Click(object sender, EventArgs e)
        {
            DayDispositionForm dayDispositionForm = new DayDispositionForm();
            var result = dayDispositionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                WorkerSelected.WeekDisposition = dayDispositionForm.Matrix;
            }
        }
    }
}
