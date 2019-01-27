namespace Planner
{
    partial class WorkerForm
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
            this.gbWorker = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbBoxGeneral = new System.Windows.Forms.GroupBox();
            this.gbAvailability = new System.Windows.Forms.GroupBox();
            this.gbPreferences = new System.Windows.Forms.GroupBox();
            this.lID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lLastname = new System.Windows.Forms.Label();
            this.lSex = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbAvailableFrom = new System.Windows.Forms.TextBox();
            this.lAvailableFrom = new System.Windows.Forms.Label();
            this.tbAvailableTo = new System.Windows.Forms.TextBox();
            this.lAvailableTo = new System.Windows.Forms.Label();
            this.tbAvailableDay = new System.Windows.Forms.TextBox();
            this.lAvailableDay = new System.Windows.Forms.Label();
            this.tbAvailableLeader = new System.Windows.Forms.TextBox();
            this.lAvailableLeader = new System.Windows.Forms.Label();
            this.tbAvailableWorker = new System.Windows.Forms.TextBox();
            this.lAvailableWorker = new System.Windows.Forms.Label();
            this.tbPreferencesWorker = new System.Windows.Forms.TextBox();
            this.lPreferencesWorker = new System.Windows.Forms.Label();
            this.tbPreferencesLeader = new System.Windows.Forms.TextBox();
            this.lPreferencesLeader = new System.Windows.Forms.Label();
            this.tbPreferencesDay = new System.Windows.Forms.TextBox();
            this.lPreferencesDay = new System.Windows.Forms.Label();
            this.tbAvailableProduction = new System.Windows.Forms.TextBox();
            this.lAvailableProduction = new System.Windows.Forms.Label();
            this.tbPreferencesProduction = new System.Windows.Forms.TextBox();
            this.lPreferencesProduction = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bAvailableDay = new System.Windows.Forms.Button();
            this.bAvailableLeader = new System.Windows.Forms.Button();
            this.bAvailableWorker = new System.Windows.Forms.Button();
            this.bAvailableProduction = new System.Windows.Forms.Button();
            this.bPreferencesDay = new System.Windows.Forms.Button();
            this.bPreferencesLeader = new System.Windows.Forms.Button();
            this.bPreferencesWorker = new System.Windows.Forms.Button();
            this.bPreferencesProduction = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lAvailableLastSundayShift = new System.Windows.Forms.Label();
            this.tbAvailableLastShift = new System.Windows.Forms.TextBox();
            this.lAvailableLastShift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.gbWorker.SuspendLayout();
            this.gbBoxGeneral.SuspendLayout();
            this.gbAvailability.SuspendLayout();
            this.gbPreferences.SuspendLayout();
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
            // gbWorker
            // 
            this.gbWorker.Controls.Add(this.bSave);
            this.gbWorker.Controls.Add(this.gbPreferences);
            this.gbWorker.Controls.Add(this.gbAvailability);
            this.gbWorker.Controls.Add(this.gbBoxGeneral);
            this.gbWorker.Location = new System.Drawing.Point(654, 12);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Size = new System.Drawing.Size(477, 618);
            this.gbWorker.TabIndex = 1;
            this.gbWorker.TabStop = false;
            this.gbWorker.Text = "Pracownik";
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
            // gbAvailability
            // 
            this.gbAvailability.Controls.Add(this.tbAvailableLastShift);
            this.gbAvailability.Controls.Add(this.lAvailableLastShift);
            this.gbAvailability.Controls.Add(this.textBox1);
            this.gbAvailability.Controls.Add(this.lAvailableLastSundayShift);
            this.gbAvailability.Controls.Add(this.bAvailableProduction);
            this.gbAvailability.Controls.Add(this.bAvailableWorker);
            this.gbAvailability.Controls.Add(this.bAvailableLeader);
            this.gbAvailability.Controls.Add(this.bAvailableDay);
            this.gbAvailability.Controls.Add(this.tbAvailableProduction);
            this.gbAvailability.Controls.Add(this.lAvailableProduction);
            this.gbAvailability.Controls.Add(this.tbAvailableWorker);
            this.gbAvailability.Controls.Add(this.lAvailableWorker);
            this.gbAvailability.Controls.Add(this.tbAvailableLeader);
            this.gbAvailability.Controls.Add(this.lAvailableLeader);
            this.gbAvailability.Controls.Add(this.tbAvailableDay);
            this.gbAvailability.Controls.Add(this.lAvailableDay);
            this.gbAvailability.Controls.Add(this.tbAvailableTo);
            this.gbAvailability.Controls.Add(this.lAvailableTo);
            this.gbAvailability.Controls.Add(this.tbAvailableFrom);
            this.gbAvailability.Controls.Add(this.lAvailableFrom);
            this.gbAvailability.Location = new System.Drawing.Point(6, 172);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(465, 254);
            this.gbAvailability.TabIndex = 1;
            this.gbAvailability.TabStop = false;
            this.gbAvailability.Text = "Dostępność";
            // 
            // gbPreferences
            // 
            this.gbPreferences.Controls.Add(this.bPreferencesProduction);
            this.gbPreferences.Controls.Add(this.bPreferencesWorker);
            this.gbPreferences.Controls.Add(this.bPreferencesLeader);
            this.gbPreferences.Controls.Add(this.bPreferencesDay);
            this.gbPreferences.Controls.Add(this.tbPreferencesProduction);
            this.gbPreferences.Controls.Add(this.lPreferencesProduction);
            this.gbPreferences.Controls.Add(this.tbPreferencesWorker);
            this.gbPreferences.Controls.Add(this.lPreferencesWorker);
            this.gbPreferences.Controls.Add(this.tbPreferencesLeader);
            this.gbPreferences.Controls.Add(this.lPreferencesLeader);
            this.gbPreferences.Controls.Add(this.tbPreferencesDay);
            this.gbPreferences.Controls.Add(this.lPreferencesDay);
            this.gbPreferences.Location = new System.Drawing.Point(6, 432);
            this.gbPreferences.Name = "gbPreferences";
            this.gbPreferences.Size = new System.Drawing.Size(465, 146);
            this.gbPreferences.TabIndex = 2;
            this.gbPreferences.TabStop = false;
            this.gbPreferences.Text = "Preferencje";
            // 
            // lID
            // 
            this.lID.Location = new System.Drawing.Point(6, 24);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(176, 22);
            this.lID.TabIndex = 0;
            this.lID.Text = "ID";
            this.lID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(188, 24);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(271, 22);
            this.tbID.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(188, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 22);
            this.tbName.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(6, 52);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(176, 22);
            this.lName.TabIndex = 2;
            this.lName.Text = "Imię";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(188, 80);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(271, 22);
            this.tbLastname.TabIndex = 5;
            // 
            // lLastname
            // 
            this.lLastname.Location = new System.Drawing.Point(6, 80);
            this.lLastname.Name = "lLastname";
            this.lLastname.Size = new System.Drawing.Size(176, 22);
            this.lLastname.TabIndex = 4;
            this.lLastname.Text = "Nazwisko";
            this.lLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSex
            // 
            this.lSex.Location = new System.Drawing.Point(6, 108);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(176, 24);
            this.lSex.TabIndex = 6;
            this.lSex.Text = "Płeć";
            this.lSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Mężczyzna",
            "Kobieta"});
            this.cbSex.Location = new System.Drawing.Point(188, 108);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(270, 24);
            this.cbSex.TabIndex = 7;
            // 
            // tbAvailableFrom
            // 
            this.tbAvailableFrom.Location = new System.Drawing.Point(189, 77);
            this.tbAvailableFrom.Name = "tbAvailableFrom";
            this.tbAvailableFrom.Size = new System.Drawing.Size(271, 22);
            this.tbAvailableFrom.TabIndex = 3;
            // 
            // lAvailableFrom
            // 
            this.lAvailableFrom.Location = new System.Drawing.Point(7, 77);
            this.lAvailableFrom.Name = "lAvailableFrom";
            this.lAvailableFrom.Size = new System.Drawing.Size(176, 22);
            this.lAvailableFrom.TabIndex = 2;
            this.lAvailableFrom.Text = "Dostępność od";
            this.lAvailableFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAvailableTo
            // 
            this.tbAvailableTo.Location = new System.Drawing.Point(189, 105);
            this.tbAvailableTo.Name = "tbAvailableTo";
            this.tbAvailableTo.Size = new System.Drawing.Size(271, 22);
            this.tbAvailableTo.TabIndex = 5;
            // 
            // lAvailableTo
            // 
            this.lAvailableTo.Location = new System.Drawing.Point(7, 105);
            this.lAvailableTo.Name = "lAvailableTo";
            this.lAvailableTo.Size = new System.Drawing.Size(176, 22);
            this.lAvailableTo.TabIndex = 4;
            this.lAvailableTo.Text = "Dostępność do";
            this.lAvailableTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAvailableDay
            // 
            this.tbAvailableDay.Location = new System.Drawing.Point(189, 133);
            this.tbAvailableDay.Name = "tbAvailableDay";
            this.tbAvailableDay.Size = new System.Drawing.Size(209, 22);
            this.tbAvailableDay.TabIndex = 7;
            // 
            // lAvailableDay
            // 
            this.lAvailableDay.Location = new System.Drawing.Point(7, 133);
            this.lAvailableDay.Name = "lAvailableDay";
            this.lAvailableDay.Size = new System.Drawing.Size(176, 22);
            this.lAvailableDay.TabIndex = 6;
            this.lAvailableDay.Text = "wg. dnia";
            this.lAvailableDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAvailableLeader
            // 
            this.tbAvailableLeader.Location = new System.Drawing.Point(189, 161);
            this.tbAvailableLeader.Name = "tbAvailableLeader";
            this.tbAvailableLeader.Size = new System.Drawing.Size(209, 22);
            this.tbAvailableLeader.TabIndex = 9;
            // 
            // lAvailableLeader
            // 
            this.lAvailableLeader.Location = new System.Drawing.Point(7, 161);
            this.lAvailableLeader.Name = "lAvailableLeader";
            this.lAvailableLeader.Size = new System.Drawing.Size(176, 22);
            this.lAvailableLeader.TabIndex = 8;
            this.lAvailableLeader.Text = "wg. brygadzisty";
            this.lAvailableLeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAvailableWorker
            // 
            this.tbAvailableWorker.Location = new System.Drawing.Point(189, 189);
            this.tbAvailableWorker.Name = "tbAvailableWorker";
            this.tbAvailableWorker.Size = new System.Drawing.Size(209, 22);
            this.tbAvailableWorker.TabIndex = 11;
            // 
            // lAvailableWorker
            // 
            this.lAvailableWorker.Location = new System.Drawing.Point(7, 189);
            this.lAvailableWorker.Name = "lAvailableWorker";
            this.lAvailableWorker.Size = new System.Drawing.Size(176, 22);
            this.lAvailableWorker.TabIndex = 10;
            this.lAvailableWorker.Text = "wg. pracownika";
            this.lAvailableWorker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPreferencesWorker
            // 
            this.tbPreferencesWorker.Location = new System.Drawing.Point(187, 77);
            this.tbPreferencesWorker.Name = "tbPreferencesWorker";
            this.tbPreferencesWorker.Size = new System.Drawing.Size(210, 22);
            this.tbPreferencesWorker.TabIndex = 17;
            // 
            // lPreferencesWorker
            // 
            this.lPreferencesWorker.Location = new System.Drawing.Point(5, 77);
            this.lPreferencesWorker.Name = "lPreferencesWorker";
            this.lPreferencesWorker.Size = new System.Drawing.Size(176, 22);
            this.lPreferencesWorker.TabIndex = 16;
            this.lPreferencesWorker.Text = "wg. pracownika";
            this.lPreferencesWorker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPreferencesLeader
            // 
            this.tbPreferencesLeader.Location = new System.Drawing.Point(187, 49);
            this.tbPreferencesLeader.Name = "tbPreferencesLeader";
            this.tbPreferencesLeader.Size = new System.Drawing.Size(210, 22);
            this.tbPreferencesLeader.TabIndex = 15;
            // 
            // lPreferencesLeader
            // 
            this.lPreferencesLeader.Location = new System.Drawing.Point(5, 49);
            this.lPreferencesLeader.Name = "lPreferencesLeader";
            this.lPreferencesLeader.Size = new System.Drawing.Size(176, 22);
            this.lPreferencesLeader.TabIndex = 14;
            this.lPreferencesLeader.Text = "wg. brygadzisty";
            this.lPreferencesLeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPreferencesDay
            // 
            this.tbPreferencesDay.Location = new System.Drawing.Point(187, 21);
            this.tbPreferencesDay.Name = "tbPreferencesDay";
            this.tbPreferencesDay.Size = new System.Drawing.Size(210, 22);
            this.tbPreferencesDay.TabIndex = 13;
            // 
            // lPreferencesDay
            // 
            this.lPreferencesDay.Location = new System.Drawing.Point(5, 21);
            this.lPreferencesDay.Name = "lPreferencesDay";
            this.lPreferencesDay.Size = new System.Drawing.Size(176, 22);
            this.lPreferencesDay.TabIndex = 12;
            this.lPreferencesDay.Text = "wg. dnia";
            this.lPreferencesDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAvailableProduction
            // 
            this.tbAvailableProduction.Location = new System.Drawing.Point(189, 217);
            this.tbAvailableProduction.Name = "tbAvailableProduction";
            this.tbAvailableProduction.Size = new System.Drawing.Size(209, 22);
            this.tbAvailableProduction.TabIndex = 13;
            // 
            // lAvailableProduction
            // 
            this.lAvailableProduction.Location = new System.Drawing.Point(7, 217);
            this.lAvailableProduction.Name = "lAvailableProduction";
            this.lAvailableProduction.Size = new System.Drawing.Size(176, 22);
            this.lAvailableProduction.TabIndex = 12;
            this.lAvailableProduction.Text = "wg. linii produkcyjnej";
            this.lAvailableProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPreferencesProduction
            // 
            this.tbPreferencesProduction.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.tbPreferencesProduction.Location = new System.Drawing.Point(188, 105);
            this.tbPreferencesProduction.Name = "tbPreferencesProduction";
            this.tbPreferencesProduction.Size = new System.Drawing.Size(209, 22);
            this.tbPreferencesProduction.TabIndex = 19;
            // 
            // lPreferencesProduction
            // 
            this.lPreferencesProduction.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lPreferencesProduction.Location = new System.Drawing.Point(6, 105);
            this.lPreferencesProduction.Name = "lPreferencesProduction";
            this.lPreferencesProduction.Size = new System.Drawing.Size(176, 22);
            this.lPreferencesProduction.TabIndex = 18;
            this.lPreferencesProduction.Text = "wg. linii produkcyjnej";
            this.lPreferencesProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(6, 584);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(458, 28);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bAvailableDay
            // 
            this.bAvailableDay.Location = new System.Drawing.Point(403, 132);
            this.bAvailableDay.Name = "bAvailableDay";
            this.bAvailableDay.Size = new System.Drawing.Size(56, 23);
            this.bAvailableDay.TabIndex = 14;
            this.bAvailableDay.Text = "...";
            this.bAvailableDay.UseVisualStyleBackColor = true;
            // 
            // bAvailableLeader
            // 
            this.bAvailableLeader.Location = new System.Drawing.Point(402, 159);
            this.bAvailableLeader.Name = "bAvailableLeader";
            this.bAvailableLeader.Size = new System.Drawing.Size(56, 23);
            this.bAvailableLeader.TabIndex = 15;
            this.bAvailableLeader.Text = "...";
            this.bAvailableLeader.UseVisualStyleBackColor = true;
            // 
            // bAvailableWorker
            // 
            this.bAvailableWorker.Location = new System.Drawing.Point(402, 187);
            this.bAvailableWorker.Name = "bAvailableWorker";
            this.bAvailableWorker.Size = new System.Drawing.Size(56, 23);
            this.bAvailableWorker.TabIndex = 16;
            this.bAvailableWorker.Text = "...";
            this.bAvailableWorker.UseVisualStyleBackColor = true;
            // 
            // bAvailableProduction
            // 
            this.bAvailableProduction.Location = new System.Drawing.Point(402, 215);
            this.bAvailableProduction.Name = "bAvailableProduction";
            this.bAvailableProduction.Size = new System.Drawing.Size(56, 23);
            this.bAvailableProduction.TabIndex = 17;
            this.bAvailableProduction.Text = "...";
            this.bAvailableProduction.UseVisualStyleBackColor = true;
            // 
            // bPreferencesDay
            // 
            this.bPreferencesDay.Location = new System.Drawing.Point(402, 20);
            this.bPreferencesDay.Name = "bPreferencesDay";
            this.bPreferencesDay.Size = new System.Drawing.Size(56, 23);
            this.bPreferencesDay.TabIndex = 18;
            this.bPreferencesDay.Text = "...";
            this.bPreferencesDay.UseVisualStyleBackColor = true;
            // 
            // bPreferencesLeader
            // 
            this.bPreferencesLeader.Location = new System.Drawing.Point(402, 49);
            this.bPreferencesLeader.Name = "bPreferencesLeader";
            this.bPreferencesLeader.Size = new System.Drawing.Size(56, 23);
            this.bPreferencesLeader.TabIndex = 20;
            this.bPreferencesLeader.Text = "...";
            this.bPreferencesLeader.UseVisualStyleBackColor = true;
            // 
            // bPreferencesWorker
            // 
            this.bPreferencesWorker.Location = new System.Drawing.Point(403, 76);
            this.bPreferencesWorker.Name = "bPreferencesWorker";
            this.bPreferencesWorker.Size = new System.Drawing.Size(56, 23);
            this.bPreferencesWorker.TabIndex = 21;
            this.bPreferencesWorker.Text = "...";
            this.bPreferencesWorker.UseVisualStyleBackColor = true;
            // 
            // bPreferencesProduction
            // 
            this.bPreferencesProduction.Location = new System.Drawing.Point(402, 104);
            this.bPreferencesProduction.Name = "bPreferencesProduction";
            this.bPreferencesProduction.Size = new System.Drawing.Size(56, 23);
            this.bPreferencesProduction.TabIndex = 22;
            this.bPreferencesProduction.Text = "...";
            this.bPreferencesProduction.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 19;
            // 
            // lAvailableLastSundayShift
            // 
            this.lAvailableLastSundayShift.Location = new System.Drawing.Point(6, 49);
            this.lAvailableLastSundayShift.Name = "lAvailableLastSundayShift";
            this.lAvailableLastSundayShift.Size = new System.Drawing.Size(176, 22);
            this.lAvailableLastSundayShift.TabIndex = 18;
            this.lAvailableLastSundayShift.Text = "Ost. zmiana niedzielna";
            this.lAvailableLastSundayShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAvailableLastShift
            // 
            this.tbAvailableLastShift.Location = new System.Drawing.Point(188, 21);
            this.tbAvailableLastShift.Name = "tbAvailableLastShift";
            this.tbAvailableLastShift.Size = new System.Drawing.Size(271, 22);
            this.tbAvailableLastShift.TabIndex = 21;
            // 
            // lAvailableLastShift
            // 
            this.lAvailableLastShift.Location = new System.Drawing.Point(6, 21);
            this.lAvailableLastShift.Name = "lAvailableLastShift";
            this.lAvailableLastShift.Size = new System.Drawing.Size(176, 22);
            this.lAvailableLastShift.TabIndex = 20;
            this.lAvailableLastShift.Text = "Ostatnia zmiana";
            this.lAvailableLastShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.gbWorker);
            this.Controls.Add(this.dgvWorkers);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.gbWorker.ResumeLayout(false);
            this.gbBoxGeneral.ResumeLayout(false);
            this.gbBoxGeneral.PerformLayout();
            this.gbAvailability.ResumeLayout(false);
            this.gbAvailability.PerformLayout();
            this.gbPreferences.ResumeLayout(false);
            this.gbPreferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.GroupBox gbWorker;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbPreferences;
        private System.Windows.Forms.GroupBox gbAvailability;
        private System.Windows.Forms.GroupBox gbBoxGeneral;
        private System.Windows.Forms.TextBox tbPreferencesWorker;
        private System.Windows.Forms.Label lPreferencesWorker;
        private System.Windows.Forms.TextBox tbPreferencesLeader;
        private System.Windows.Forms.Label lPreferencesLeader;
        private System.Windows.Forms.TextBox tbPreferencesDay;
        private System.Windows.Forms.Label lPreferencesDay;
        private System.Windows.Forms.TextBox tbAvailableWorker;
        private System.Windows.Forms.Label lAvailableWorker;
        private System.Windows.Forms.TextBox tbAvailableLeader;
        private System.Windows.Forms.Label lAvailableLeader;
        private System.Windows.Forms.TextBox tbAvailableDay;
        private System.Windows.Forms.Label lAvailableDay;
        private System.Windows.Forms.TextBox tbAvailableTo;
        private System.Windows.Forms.Label lAvailableTo;
        private System.Windows.Forms.TextBox tbAvailableFrom;
        private System.Windows.Forms.Label lAvailableFrom;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label lLastname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbPreferencesProduction;
        private System.Windows.Forms.Label lPreferencesProduction;
        private System.Windows.Forms.TextBox tbAvailableProduction;
        private System.Windows.Forms.Label lAvailableProduction;
        private System.Windows.Forms.Button bPreferencesProduction;
        private System.Windows.Forms.Button bPreferencesWorker;
        private System.Windows.Forms.Button bPreferencesLeader;
        private System.Windows.Forms.Button bPreferencesDay;
        private System.Windows.Forms.Button bAvailableProduction;
        private System.Windows.Forms.Button bAvailableWorker;
        private System.Windows.Forms.Button bAvailableLeader;
        private System.Windows.Forms.Button bAvailableDay;
        private System.Windows.Forms.TextBox tbAvailableLastShift;
        private System.Windows.Forms.Label lAvailableLastShift;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lAvailableLastSundayShift;
    }
}