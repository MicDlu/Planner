namespace Planner
{
    partial class WorkerSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.gbWorkerSetup = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.gbFixed = new System.Windows.Forms.GroupBox();
            this.bFixedProduction = new System.Windows.Forms.Button();
            this.bFixedWorker = new System.Windows.Forms.Button();
            this.bFixedLeader = new System.Windows.Forms.Button();
            this.bFixedDay = new System.Windows.Forms.Button();
            this.tbFixedProduction = new System.Windows.Forms.TextBox();
            this.lFixedProduction = new System.Windows.Forms.Label();
            this.tbFixedWorker = new System.Windows.Forms.TextBox();
            this.lFixedWorker = new System.Windows.Forms.Label();
            this.tbFixedLeader = new System.Windows.Forms.TextBox();
            this.lFixedLeader = new System.Windows.Forms.Label();
            this.tbFixedDay = new System.Windows.Forms.TextBox();
            this.lFixedDay = new System.Windows.Forms.Label();
            this.gbActual = new System.Windows.Forms.GroupBox();
            this.bActualWeekAvailability = new System.Windows.Forms.Button();
            this.tbActualWeekAvailability = new System.Windows.Forms.TextBox();
            this.lActualWeekAvailability = new System.Windows.Forms.Label();
            this.tbActualLastFreeSunday = new System.Windows.Forms.TextBox();
            this.lActualLastFreeSunday = new System.Windows.Forms.Label();
            this.tbActualLastFreeDay = new System.Windows.Forms.TextBox();
            this.lActualLastFreeDay = new System.Windows.Forms.Label();
            this.tbActualPriority = new System.Windows.Forms.TextBox();
            this.lActualPriority = new System.Windows.Forms.Label();
            this.tbActualLastShift = new System.Windows.Forms.TextBox();
            this.lActualLastShift = new System.Windows.Forms.Label();
            this.tbActualTo = new System.Windows.Forms.TextBox();
            this.lActualTo = new System.Windows.Forms.Label();
            this.tbActualFrom = new System.Windows.Forms.TextBox();
            this.lActualFrom = new System.Windows.Forms.Label();
            this.gbBoxGeneral = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lSex = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lLastname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.gbWorkerSetup.SuspendLayout();
            this.gbFixed.SuspendLayout();
            this.gbActual.SuspendLayout();
            this.gbBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.AllowUserToResizeColumns = false;
            this.dgvWorkers.AllowUserToResizeRows = false;
            this.dgvWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(12, 12);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(636, 659);
            this.dgvWorkers.TabIndex = 0;
            this.dgvWorkers.SelectionChanged += new System.EventHandler(this.dgvWorkers_SelectionChanged);
            // 
            // gbWorkerSetup
            // 
            this.gbWorkerSetup.Controls.Add(this.bSave);
            this.gbWorkerSetup.Controls.Add(this.gbFixed);
            this.gbWorkerSetup.Controls.Add(this.gbActual);
            this.gbWorkerSetup.Controls.Add(this.gbBoxGeneral);
            this.gbWorkerSetup.Location = new System.Drawing.Point(654, 12);
            this.gbWorkerSetup.Name = "gbWorkerSetup";
            this.gbWorkerSetup.Size = new System.Drawing.Size(477, 593);
            this.gbWorkerSetup.TabIndex = 1;
            this.gbWorkerSetup.TabStop = false;
            this.gbWorkerSetup.Text = "Ustawienia pracownika";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(0, 556);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(465, 28);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // gbFixed
            // 
            this.gbFixed.Controls.Add(this.bFixedProduction);
            this.gbFixed.Controls.Add(this.bFixedWorker);
            this.gbFixed.Controls.Add(this.bFixedLeader);
            this.gbFixed.Controls.Add(this.bFixedDay);
            this.gbFixed.Controls.Add(this.tbFixedProduction);
            this.gbFixed.Controls.Add(this.lFixedProduction);
            this.gbFixed.Controls.Add(this.tbFixedWorker);
            this.gbFixed.Controls.Add(this.lFixedWorker);
            this.gbFixed.Controls.Add(this.tbFixedLeader);
            this.gbFixed.Controls.Add(this.lFixedLeader);
            this.gbFixed.Controls.Add(this.tbFixedDay);
            this.gbFixed.Controls.Add(this.lFixedDay);
            this.gbFixed.Location = new System.Drawing.Point(6, 404);
            this.gbFixed.Name = "gbFixed";
            this.gbFixed.Size = new System.Drawing.Size(465, 146);
            this.gbFixed.TabIndex = 2;
            this.gbFixed.TabStop = false;
            this.gbFixed.Text = "Stała dyspozycja";
            // 
            // bFixedProduction
            // 
            this.bFixedProduction.Location = new System.Drawing.Point(402, 104);
            this.bFixedProduction.Name = "bFixedProduction";
            this.bFixedProduction.Size = new System.Drawing.Size(56, 23);
            this.bFixedProduction.TabIndex = 22;
            this.bFixedProduction.Text = "...";
            this.bFixedProduction.UseVisualStyleBackColor = true;
            // 
            // bFixedWorker
            // 
            this.bFixedWorker.Enabled = false;
            this.bFixedWorker.Location = new System.Drawing.Point(403, 76);
            this.bFixedWorker.Name = "bFixedWorker";
            this.bFixedWorker.Size = new System.Drawing.Size(56, 23);
            this.bFixedWorker.TabIndex = 21;
            this.bFixedWorker.Text = "...";
            this.bFixedWorker.UseVisualStyleBackColor = true;
            // 
            // bFixedLeader
            // 
            this.bFixedLeader.Enabled = false;
            this.bFixedLeader.Location = new System.Drawing.Point(402, 49);
            this.bFixedLeader.Name = "bFixedLeader";
            this.bFixedLeader.Size = new System.Drawing.Size(56, 23);
            this.bFixedLeader.TabIndex = 20;
            this.bFixedLeader.Text = "...";
            this.bFixedLeader.UseVisualStyleBackColor = true;
            // 
            // bFixedDay
            // 
            this.bFixedDay.Location = new System.Drawing.Point(402, 20);
            this.bFixedDay.Name = "bFixedDay";
            this.bFixedDay.Size = new System.Drawing.Size(56, 23);
            this.bFixedDay.TabIndex = 18;
            this.bFixedDay.Text = "...";
            this.bFixedDay.UseVisualStyleBackColor = true;
            // 
            // tbFixedProduction
            // 
            this.tbFixedProduction.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.tbFixedProduction.Location = new System.Drawing.Point(214, 105);
            this.tbFixedProduction.Name = "tbFixedProduction";
            this.tbFixedProduction.Size = new System.Drawing.Size(183, 22);
            this.tbFixedProduction.TabIndex = 19;
            // 
            // lFixedProduction
            // 
            this.lFixedProduction.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lFixedProduction.Location = new System.Drawing.Point(6, 105);
            this.lFixedProduction.Name = "lFixedProduction";
            this.lFixedProduction.Size = new System.Drawing.Size(202, 22);
            this.lFixedProduction.TabIndex = 18;
            this.lFixedProduction.Text = "wg. linii produkcyjnej";
            this.lFixedProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFixedWorker
            // 
            this.tbFixedWorker.Enabled = false;
            this.tbFixedWorker.Location = new System.Drawing.Point(213, 77);
            this.tbFixedWorker.Name = "tbFixedWorker";
            this.tbFixedWorker.Size = new System.Drawing.Size(184, 22);
            this.tbFixedWorker.TabIndex = 17;
            // 
            // lFixedWorker
            // 
            this.lFixedWorker.Enabled = false;
            this.lFixedWorker.Location = new System.Drawing.Point(5, 77);
            this.lFixedWorker.Name = "lFixedWorker";
            this.lFixedWorker.Size = new System.Drawing.Size(202, 22);
            this.lFixedWorker.TabIndex = 16;
            this.lFixedWorker.Text = "wg. pracownika";
            this.lFixedWorker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFixedLeader
            // 
            this.tbFixedLeader.Enabled = false;
            this.tbFixedLeader.Location = new System.Drawing.Point(213, 49);
            this.tbFixedLeader.Name = "tbFixedLeader";
            this.tbFixedLeader.Size = new System.Drawing.Size(184, 22);
            this.tbFixedLeader.TabIndex = 15;
            // 
            // lFixedLeader
            // 
            this.lFixedLeader.Enabled = false;
            this.lFixedLeader.Location = new System.Drawing.Point(5, 49);
            this.lFixedLeader.Name = "lFixedLeader";
            this.lFixedLeader.Size = new System.Drawing.Size(202, 22);
            this.lFixedLeader.TabIndex = 14;
            this.lFixedLeader.Text = "wg. brygadzisty";
            this.lFixedLeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFixedDay
            // 
            this.tbFixedDay.Location = new System.Drawing.Point(213, 21);
            this.tbFixedDay.Name = "tbFixedDay";
            this.tbFixedDay.Size = new System.Drawing.Size(184, 22);
            this.tbFixedDay.TabIndex = 13;
            // 
            // lFixedDay
            // 
            this.lFixedDay.Location = new System.Drawing.Point(5, 21);
            this.lFixedDay.Name = "lFixedDay";
            this.lFixedDay.Size = new System.Drawing.Size(202, 22);
            this.lFixedDay.TabIndex = 12;
            this.lFixedDay.Text = "wg. dnia";
            this.lFixedDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbActual
            // 
            this.gbActual.Controls.Add(this.bActualWeekAvailability);
            this.gbActual.Controls.Add(this.tbActualWeekAvailability);
            this.gbActual.Controls.Add(this.lActualWeekAvailability);
            this.gbActual.Controls.Add(this.tbActualLastFreeSunday);
            this.gbActual.Controls.Add(this.lActualLastFreeSunday);
            this.gbActual.Controls.Add(this.tbActualLastFreeDay);
            this.gbActual.Controls.Add(this.lActualLastFreeDay);
            this.gbActual.Controls.Add(this.tbActualPriority);
            this.gbActual.Controls.Add(this.lActualPriority);
            this.gbActual.Controls.Add(this.tbActualLastShift);
            this.gbActual.Controls.Add(this.lActualLastShift);
            this.gbActual.Controls.Add(this.tbActualTo);
            this.gbActual.Controls.Add(this.lActualTo);
            this.gbActual.Controls.Add(this.tbActualFrom);
            this.gbActual.Controls.Add(this.lActualFrom);
            this.gbActual.Location = new System.Drawing.Point(6, 172);
            this.gbActual.Name = "gbActual";
            this.gbActual.Size = new System.Drawing.Size(465, 226);
            this.gbActual.TabIndex = 1;
            this.gbActual.TabStop = false;
            this.gbActual.Text = "Aktualne";
            // 
            // bActualWeekAvailability
            // 
            this.bActualWeekAvailability.Location = new System.Drawing.Point(403, 189);
            this.bActualWeekAvailability.Name = "bActualWeekAvailability";
            this.bActualWeekAvailability.Size = new System.Drawing.Size(56, 23);
            this.bActualWeekAvailability.TabIndex = 30;
            this.bActualWeekAvailability.Text = "...";
            this.bActualWeekAvailability.UseVisualStyleBackColor = true;
            this.bActualWeekAvailability.Click += new System.EventHandler(this.bActualWeekAvailability_Click);
            // 
            // tbActualWeekAvailability
            // 
            this.tbActualWeekAvailability.Location = new System.Drawing.Point(214, 190);
            this.tbActualWeekAvailability.Name = "tbActualWeekAvailability";
            this.tbActualWeekAvailability.Size = new System.Drawing.Size(184, 22);
            this.tbActualWeekAvailability.TabIndex = 29;
            // 
            // lActualWeekAvailability
            // 
            this.lActualWeekAvailability.Location = new System.Drawing.Point(6, 190);
            this.lActualWeekAvailability.Name = "lActualWeekAvailability";
            this.lActualWeekAvailability.Size = new System.Drawing.Size(202, 22);
            this.lActualWeekAvailability.TabIndex = 28;
            this.lActualWeekAvailability.Text = "Dyspozycja w tym tygodniu";
            this.lActualWeekAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActualLastFreeSunday
            // 
            this.tbActualLastFreeSunday.Location = new System.Drawing.Point(214, 161);
            this.tbActualLastFreeSunday.Name = "tbActualLastFreeSunday";
            this.tbActualLastFreeSunday.Size = new System.Drawing.Size(245, 22);
            this.tbActualLastFreeSunday.TabIndex = 27;
            // 
            // lActualLastFreeSunday
            // 
            this.lActualLastFreeSunday.Location = new System.Drawing.Point(6, 161);
            this.lActualLastFreeSunday.Name = "lActualLastFreeSunday";
            this.lActualLastFreeSunday.Size = new System.Drawing.Size(202, 22);
            this.lActualLastFreeSunday.TabIndex = 26;
            this.lActualLastFreeSunday.Text = "Poprzednia wolna niedziela";
            this.lActualLastFreeSunday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActualLastFreeDay
            // 
            this.tbActualLastFreeDay.Location = new System.Drawing.Point(214, 133);
            this.tbActualLastFreeDay.Name = "tbActualLastFreeDay";
            this.tbActualLastFreeDay.Size = new System.Drawing.Size(245, 22);
            this.tbActualLastFreeDay.TabIndex = 25;
            // 
            // lActualLastFreeDay
            // 
            this.lActualLastFreeDay.Location = new System.Drawing.Point(6, 133);
            this.lActualLastFreeDay.Name = "lActualLastFreeDay";
            this.lActualLastFreeDay.Size = new System.Drawing.Size(202, 22);
            this.lActualLastFreeDay.TabIndex = 24;
            this.lActualLastFreeDay.Text = "Poprzedni dzień wolny";
            this.lActualLastFreeDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActualPriority
            // 
            this.tbActualPriority.Location = new System.Drawing.Point(214, 77);
            this.tbActualPriority.Name = "tbActualPriority";
            this.tbActualPriority.Size = new System.Drawing.Size(245, 22);
            this.tbActualPriority.TabIndex = 23;
            // 
            // lActualPriority
            // 
            this.lActualPriority.Location = new System.Drawing.Point(6, 77);
            this.lActualPriority.Name = "lActualPriority";
            this.lActualPriority.Size = new System.Drawing.Size(202, 22);
            this.lActualPriority.TabIndex = 22;
            this.lActualPriority.Text = "Priorytet";
            this.lActualPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActualLastShift
            // 
            this.tbActualLastShift.Location = new System.Drawing.Point(214, 105);
            this.tbActualLastShift.Name = "tbActualLastShift";
            this.tbActualLastShift.Size = new System.Drawing.Size(245, 22);
            this.tbActualLastShift.TabIndex = 21;
            // 
            // lActualLastShift
            // 
            this.lActualLastShift.Location = new System.Drawing.Point(6, 105);
            this.lActualLastShift.Name = "lActualLastShift";
            this.lActualLastShift.Size = new System.Drawing.Size(202, 22);
            this.lActualLastShift.TabIndex = 20;
            this.lActualLastShift.Text = "Ostatnia zmiana";
            this.lActualLastShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActualTo
            // 
            this.tbActualTo.Location = new System.Drawing.Point(214, 49);
            this.tbActualTo.Name = "tbActualTo";
            this.tbActualTo.Size = new System.Drawing.Size(245, 22);
            this.tbActualTo.TabIndex = 5;
            // 
            // lActualTo
            // 
            this.lActualTo.Location = new System.Drawing.Point(6, 49);
            this.lActualTo.Name = "lActualTo";
            this.lActualTo.Size = new System.Drawing.Size(202, 22);
            this.lActualTo.TabIndex = 4;
            this.lActualTo.Text = "Dostępność do";
            this.lActualTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActualFrom
            // 
            this.tbActualFrom.Location = new System.Drawing.Point(214, 21);
            this.tbActualFrom.Name = "tbActualFrom";
            this.tbActualFrom.Size = new System.Drawing.Size(245, 22);
            this.tbActualFrom.TabIndex = 3;
            // 
            // lActualFrom
            // 
            this.lActualFrom.Location = new System.Drawing.Point(6, 21);
            this.lActualFrom.Name = "lActualFrom";
            this.lActualFrom.Size = new System.Drawing.Size(202, 22);
            this.lActualFrom.TabIndex = 2;
            this.lActualFrom.Text = "Dostępność od";
            this.lActualFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBoxGeneral
            // 
            this.gbBoxGeneral.Controls.Add(this.cbSex);
            this.gbBoxGeneral.Controls.Add(this.lSex);
            this.gbBoxGeneral.Controls.Add(this.tbLastname);
            this.gbBoxGeneral.Controls.Add(this.lLastname);
            this.gbBoxGeneral.Controls.Add(this.tbName);
            this.gbBoxGeneral.Controls.Add(this.lName);
            this.gbBoxGeneral.Controls.Add(this.tbID);
            this.gbBoxGeneral.Controls.Add(this.lID);
            this.gbBoxGeneral.Location = new System.Drawing.Point(6, 21);
            this.gbBoxGeneral.Name = "gbBoxGeneral";
            this.gbBoxGeneral.Size = new System.Drawing.Size(465, 145);
            this.gbBoxGeneral.TabIndex = 0;
            this.gbBoxGeneral.TabStop = false;
            this.gbBoxGeneral.Text = "Ogólne";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Mężczyzna",
            "Kobieta"});
            this.cbSex.Location = new System.Drawing.Point(214, 108);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(244, 24);
            this.cbSex.TabIndex = 7;
            // 
            // lSex
            // 
            this.lSex.Location = new System.Drawing.Point(6, 108);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(202, 24);
            this.lSex.TabIndex = 6;
            this.lSex.Text = "Płeć";
            this.lSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(214, 80);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(245, 22);
            this.tbLastname.TabIndex = 5;
            // 
            // lLastname
            // 
            this.lLastname.Location = new System.Drawing.Point(6, 80);
            this.lLastname.Name = "lLastname";
            this.lLastname.Size = new System.Drawing.Size(202, 22);
            this.lLastname.TabIndex = 4;
            this.lLastname.Text = "Nazwisko";
            this.lLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(214, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 22);
            this.tbName.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(6, 52);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(202, 22);
            this.lName.TabIndex = 2;
            this.lName.Text = "Imię";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(214, 24);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(245, 22);
            this.tbID.TabIndex = 1;
            // 
            // lID
            // 
            this.lID.Location = new System.Drawing.Point(6, 24);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(202, 22);
            this.lID.TabIndex = 0;
            this.lID.Text = "ID";
            this.lID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(893, 636);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(238, 35);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(654, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WorkerSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.gbWorkerSetup);
            this.Controls.Add(this.dgvWorkers);
            this.Name = "WorkerSetupForm";
            this.Text = "WorkerSetupForm";
            this.Load += new System.EventHandler(this.WorkerSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.gbWorkerSetup.ResumeLayout(false);
            this.gbFixed.ResumeLayout(false);
            this.gbFixed.PerformLayout();
            this.gbActual.ResumeLayout(false);
            this.gbActual.PerformLayout();
            this.gbBoxGeneral.ResumeLayout(false);
            this.gbBoxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.GroupBox gbWorkerSetup;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbFixed;
        private System.Windows.Forms.GroupBox gbActual;
        private System.Windows.Forms.GroupBox gbBoxGeneral;
        private System.Windows.Forms.TextBox tbFixedWorker;
        private System.Windows.Forms.Label lFixedWorker;
        private System.Windows.Forms.TextBox tbFixedLeader;
        private System.Windows.Forms.Label lFixedLeader;
        private System.Windows.Forms.TextBox tbFixedDay;
        private System.Windows.Forms.Label lFixedDay;
        private System.Windows.Forms.TextBox tbActualTo;
        private System.Windows.Forms.Label lActualTo;
        private System.Windows.Forms.TextBox tbActualFrom;
        private System.Windows.Forms.Label lActualFrom;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label lLastname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbFixedProduction;
        private System.Windows.Forms.Label lFixedProduction;
        private System.Windows.Forms.Button bFixedProduction;
        private System.Windows.Forms.Button bFixedWorker;
        private System.Windows.Forms.Button bFixedLeader;
        private System.Windows.Forms.Button bFixedDay;
        private System.Windows.Forms.TextBox tbActualLastShift;
        private System.Windows.Forms.Label lActualLastShift;
        private System.Windows.Forms.Button bActualWeekAvailability;
        private System.Windows.Forms.TextBox tbActualWeekAvailability;
        private System.Windows.Forms.Label lActualWeekAvailability;
        private System.Windows.Forms.TextBox tbActualLastFreeSunday;
        private System.Windows.Forms.Label lActualLastFreeSunday;
        private System.Windows.Forms.TextBox tbActualLastFreeDay;
        private System.Windows.Forms.Label lActualLastFreeDay;
        private System.Windows.Forms.TextBox tbActualPriority;
        private System.Windows.Forms.Label lActualPriority;
    }
}