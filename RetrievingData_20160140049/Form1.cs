using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetrievingData_20160140049
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.Columns["sexDataGrid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.Columns["nimDataGrid"].DefaultCellStyle.SelectionBackColor = Color.Crimson;
            dataGrid.Columns["nimDataGrid"].DefaultCellStyle.ForeColor = Color.DarkRed;

            dataGrid.Columns["namaMhsDataGrid"].DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
            dataGrid.Columns["namaMhsDataGrid"].DefaultCellStyle.ForeColor = Color.DarkOliveGreen;

            dataGrid.Columns["alamatMhsDataGrid"].DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGrid.Columns["alamatMhsDataGrid"].DefaultCellStyle.ForeColor = Color.DeepSkyBlue;

            dataGrid.Columns["sexDataGrid"].DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            dataGrid.Columns["sexDataGrid"].DefaultCellStyle.ForeColor = Color.Maroon;

            dataGrid.Columns["phoneMhsDataGrid"].DefaultCellStyle.SelectionBackColor = Color.SaddleBrown;
            dataGrid.Columns["phoneMhsDataGrid"].DefaultCellStyle.ForeColor = Color.SandyBrown;

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

        }
    }
}
