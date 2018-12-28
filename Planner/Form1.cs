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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string excelFilePath = LoadExcelFileDialog();
            MessageBox.Show(excelFilePath);
        }

        private string LoadExcelFileDialog()
        {
            openFileDialog_ChooseFile.Title = "Wybierz plik planera";
            openFileDialog_ChooseFile.Filter = "Plik excel|*.xlsx";
            if (openFileDialog_ChooseFile.ShowDialog() != DialogResult.OK)
            {

            }
            else
                Application.Exit();
            return openFileDialog_ChooseFile.FileName;
        }
    }
}
