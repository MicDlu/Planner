namespace Planner
{
    partial class WorkScheduleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxEmpolyees = new System.Windows.Forms.ListBox();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxEmployees.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeadersWidthChanged += new System.EventHandler(this.dataGridView1_RowHeadersWidthChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // listBoxEmpolyees
            // 
            this.listBoxEmpolyees.FormattingEnabled = true;
            this.listBoxEmpolyees.ItemHeight = 16;
            this.listBoxEmpolyees.Location = new System.Drawing.Point(6, 23);
            this.listBoxEmpolyees.Name = "listBoxEmpolyees";
            this.listBoxEmpolyees.Size = new System.Drawing.Size(323, 244);
            this.listBoxEmpolyees.TabIndex = 1;
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Controls.Add(this.buttonAddEmployee);
            this.groupBoxEmployees.Controls.Add(this.buttonRemoveEmployee);
            this.groupBoxEmployees.Controls.Add(this.listBoxEmpolyees);
            this.groupBoxEmployees.Location = new System.Drawing.Point(614, 137);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(335, 311);
            this.groupBoxEmployees.TabIndex = 2;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Przypisani pracownicy";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(254, 273);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 32);
            this.buttonAddEmployee.TabIndex = 3;
            this.buttonAddEmployee.Text = "Dodaj...";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(6, 273);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(75, 32);
            this.buttonRemoveEmployee.TabIndex = 2;
            this.buttonRemoveEmployee.Text = "Usuń";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(6, 21);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(323, 24);
            this.comboBoxGender.TabIndex = 4;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // groupBoxView
            // 
            this.groupBoxView.Controls.Add(this.comboBoxGender);
            this.groupBoxView.Location = new System.Drawing.Point(614, 31);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(335, 61);
            this.groupBoxView.TabIndex = 5;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "Wyświetlanie";
            // 
            // WorkScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 476);
            this.Controls.Add(this.groupBoxView);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "WorkScheduleForm";
            this.Text = "WeekWorkSchedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkScheduleForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBoxView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxEmpolyees;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Button buttonAddEmployee;
    }
}