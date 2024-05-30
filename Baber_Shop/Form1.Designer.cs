namespace Baber_Shop
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
            this.Pelanggan = new System.Windows.Forms.Button();
            this.Antrian = new System.Windows.Forms.Button();
            this.Pembookingan = new System.Windows.Forms.Button();
            this.TukangCukur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barberShopDataSet = new Baber_Shop.BarberShopDataSet();
            this.antrianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antrianTableAdapter = new Baber_Shop.BarberShopDataSetTableAdapters.AntrianTableAdapter();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noantrianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktutungguDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idantrianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pelanggan
            // 
            this.Pelanggan.Location = new System.Drawing.Point(50, 30);
            this.Pelanggan.Name = "Pelanggan";
            this.Pelanggan.Size = new System.Drawing.Size(200, 40);
            this.Pelanggan.TabIndex = 0;
            this.Pelanggan.Text = "Data Pelanggan";
            this.Pelanggan.UseVisualStyleBackColor = true;
            this.Pelanggan.Click += new System.EventHandler(this.Pelanggan_Click);
            // 
            // Antrian
            // 
            this.Antrian.Location = new System.Drawing.Point(50, 90);
            this.Antrian.Name = "Antrian";
            this.Antrian.Size = new System.Drawing.Size(200, 40);
            this.Antrian.TabIndex = 1;
            this.Antrian.Text = "Pengelolaan Antrian";
            this.Antrian.UseVisualStyleBackColor = true;
            this.Antrian.Click += new System.EventHandler(this.Antrian_Click);
            // 
            // Pembookingan
            // 
            this.Pembookingan.Location = new System.Drawing.Point(50, 150);
            this.Pembookingan.Name = "Pembookingan";
            this.Pembookingan.Size = new System.Drawing.Size(200, 40);
            this.Pembookingan.TabIndex = 2;
            this.Pembookingan.Text = "Pembookingan";
            this.Pembookingan.UseVisualStyleBackColor = true;
            this.Pembookingan.Click += new System.EventHandler(this.Pembookingan_Click);
            // 
            // TukangCukur
            // 
            this.TukangCukur.Location = new System.Drawing.Point(50, 210);
            this.TukangCukur.Name = "TukangCukur";
            this.TukangCukur.Size = new System.Drawing.Size(200, 40);
            this.TukangCukur.TabIndex = 3;
            this.TukangCukur.Text = "Data Tukang Cukur";
            this.TukangCukur.UseVisualStyleBackColor = true;
            this.TukangCukur.Click += new System.EventHandler(this.TukangCukur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namapelangganDataGridViewTextBoxColumn,
            this.noantrianDataGridViewTextBoxColumn,
            this.waktutungguDataGridViewTextBoxColumn,
            this.idantrianDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.antrianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(305, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // antrianBindingSource
            // 
            this.antrianBindingSource.DataMember = "Antrian";
            this.antrianBindingSource.DataSource = this.barberShopDataSet;
            // 
            // antrianTableAdapter
            // 
            this.antrianTableAdapter.ClearBeforeFill = true;
            // 
            // namapelangganDataGridViewTextBoxColumn
            // 
            this.namapelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.HeaderText = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapelangganDataGridViewTextBoxColumn.Name = "namapelangganDataGridViewTextBoxColumn";
            this.namapelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // noantrianDataGridViewTextBoxColumn
            // 
            this.noantrianDataGridViewTextBoxColumn.DataPropertyName = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.HeaderText = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noantrianDataGridViewTextBoxColumn.Name = "noantrianDataGridViewTextBoxColumn";
            this.noantrianDataGridViewTextBoxColumn.Width = 125;
            // 
            // waktutungguDataGridViewTextBoxColumn
            // 
            this.waktutungguDataGridViewTextBoxColumn.DataPropertyName = "Waktu_tunggu";
            this.waktutungguDataGridViewTextBoxColumn.HeaderText = "Waktu_tunggu";
            this.waktutungguDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktutungguDataGridViewTextBoxColumn.Name = "waktutungguDataGridViewTextBoxColumn";
            this.waktutungguDataGridViewTextBoxColumn.Width = 125;
            // 
            // idantrianDataGridViewTextBoxColumn
            // 
            this.idantrianDataGridViewTextBoxColumn.DataPropertyName = "Id_antrian";
            this.idantrianDataGridViewTextBoxColumn.HeaderText = "Id_antrian";
            this.idantrianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idantrianDataGridViewTextBoxColumn.Name = "idantrianDataGridViewTextBoxColumn";
            this.idantrianDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1037, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pelanggan);
            this.Controls.Add(this.Antrian);
            this.Controls.Add(this.Pembookingan);
            this.Controls.Add(this.TukangCukur);
            this.Name = "Form1";
            this.Text = "Barber Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource antrianBindingSource;
        private BarberShopDataSetTableAdapters.AntrianTableAdapter antrianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktutungguDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idantrianDataGridViewTextBoxColumn;
    }
}

