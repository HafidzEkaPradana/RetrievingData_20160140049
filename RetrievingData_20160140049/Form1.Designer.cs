
namespace RetrievingData_20160140049
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new RetrievingData_20160140049.ProdiTIDataSet();
            this.mahasiswaTableAdapter = new RetrievingData_20160140049.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.nimDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMhsDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatMhsDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMhsDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGrid,
            this.namaMhsDataGrid,
            this.alamatMhsDataGrid,
            this.sexDataGrid,
            this.phoneMhsDataGrid});
            this.dataGrid.DataSource = this.mahasiswaBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(26, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(814, 400);
            this.dataGrid.TabIndex = 0;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // nimDataGrid
            // 
            this.nimDataGrid.DataPropertyName = "NIM";
            this.nimDataGrid.FillWeight = 34.53333F;
            this.nimDataGrid.HeaderText = "NIM";
            this.nimDataGrid.MinimumWidth = 8;
            this.nimDataGrid.Name = "nimDataGrid";
            this.nimDataGrid.Width = 150;
            // 
            // namaMhsDataGrid
            // 
            this.namaMhsDataGrid.DataPropertyName = "NamaMhs";
            this.namaMhsDataGrid.FillWeight = 70.54539F;
            this.namaMhsDataGrid.HeaderText = "NamaMhs";
            this.namaMhsDataGrid.MinimumWidth = 8;
            this.namaMhsDataGrid.Name = "namaMhsDataGrid";
            this.namaMhsDataGrid.Width = 171;
            // 
            // alamatMhsDataGrid
            // 
            this.alamatMhsDataGrid.DataPropertyName = "AlamatMhs";
            this.alamatMhsDataGrid.FillWeight = 89.52988F;
            this.alamatMhsDataGrid.HeaderText = "AlamatMhs";
            this.alamatMhsDataGrid.MinimumWidth = 8;
            this.alamatMhsDataGrid.Name = "alamatMhsDataGrid";
            this.alamatMhsDataGrid.Width = 180;
            // 
            // sexDataGrid
            // 
            this.sexDataGrid.DataPropertyName = "Sex";
            this.sexDataGrid.FillWeight = 59.3444F;
            this.sexDataGrid.HeaderText = "Sex";
            this.sexDataGrid.MinimumWidth = 8;
            this.sexDataGrid.Name = "sexDataGrid";
            this.sexDataGrid.Width = 69;
            // 
            // phoneMhsDataGrid
            // 
            this.phoneMhsDataGrid.DataPropertyName = "PhoneMhs";
            this.phoneMhsDataGrid.FillWeight = 96.04697F;
            this.phoneMhsDataGrid.HeaderText = "PhoneMhs";
            this.phoneMhsDataGrid.MinimumWidth = 8;
            this.phoneMhsDataGrid.Name = "phoneMhsDataGrid";
            this.phoneMhsDataGrid.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMhsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatMhsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneMhsDataGrid;
    }
}

