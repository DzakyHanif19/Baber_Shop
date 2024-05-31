namespace Baber_Shop
{
    partial class Tukang_Cukur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barberShopDataSet = new Baber_Shop.BarberShopDataSet();
            this.tukangCukurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurTableAdapter = new Baber_Shop.BarberShopDataSetTableAdapters.TukangCukurTableAdapter();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalkerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengalamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTkgCukurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tukangCukurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tukangCukurBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Tukang Cukur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Tukang Cukur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jadwal Kerja :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pengalaman :";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource3, "Jadwal_kerja", true));
            this.textBox1.Location = new System.Drawing.Point(50, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource1, "Id_TkgCukur", true));
            this.textBox2.Location = new System.Drawing.Point(50, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource2, "Nama", true));
            this.textBox3.Location = new System.Drawing.Point(50, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tukangCukurBindingSource4, "pengalaman", true));
            this.textBox4.Location = new System.Drawing.Point(50, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(277, 22);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Update_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.jadwalkerjaDataGridViewTextBoxColumn,
            this.pengalamanDataGridViewTextBoxColumn,
            this.idTkgCukurDataGridViewTextBoxColumn,
            this.idPelangganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tukangCukurBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(402, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tukangCukurBindingSource
            // 
            this.tukangCukurBindingSource.DataMember = "TukangCukur";
            this.tukangCukurBindingSource.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurTableAdapter
            // 
            this.tukangCukurTableAdapter.ClearBeforeFill = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jadwalkerjaDataGridViewTextBoxColumn
            // 
            this.jadwalkerjaDataGridViewTextBoxColumn.DataPropertyName = "Jadwal_kerja";
            this.jadwalkerjaDataGridViewTextBoxColumn.HeaderText = "Jadwal_kerja";
            this.jadwalkerjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jadwalkerjaDataGridViewTextBoxColumn.Name = "jadwalkerjaDataGridViewTextBoxColumn";
            this.jadwalkerjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pengalamanDataGridViewTextBoxColumn
            // 
            this.pengalamanDataGridViewTextBoxColumn.DataPropertyName = "pengalaman";
            this.pengalamanDataGridViewTextBoxColumn.HeaderText = "pengalaman";
            this.pengalamanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pengalamanDataGridViewTextBoxColumn.Name = "pengalamanDataGridViewTextBoxColumn";
            this.pengalamanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTkgCukurDataGridViewTextBoxColumn
            // 
            this.idTkgCukurDataGridViewTextBoxColumn.DataPropertyName = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.HeaderText = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTkgCukurDataGridViewTextBoxColumn.Name = "idTkgCukurDataGridViewTextBoxColumn";
            this.idTkgCukurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            this.idPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // tukangCukurBindingSource1
            // 
            this.tukangCukurBindingSource1.DataMember = "TukangCukur";
            this.tukangCukurBindingSource1.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurBindingSource2
            // 
            this.tukangCukurBindingSource2.DataMember = "TukangCukur";
            this.tukangCukurBindingSource2.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurBindingSource3
            // 
            this.tukangCukurBindingSource3.DataMember = "TukangCukur";
            this.tukangCukurBindingSource3.DataSource = this.barberShopDataSet;
            // 
            // tukangCukurBindingSource4
            // 
            this.tukangCukurBindingSource4.DataMember = "TukangCukur";
            this.tukangCukurBindingSource4.DataSource = this.barberShopDataSet;
            // 
            // Tukang_Cukur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tukang_Cukur";
            this.Text = "Tukang_Cukur";
            this.Load += new System.EventHandler(this.Tukang_Cukur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tukangCukurBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource;
        private BarberShopDataSetTableAdapters.TukangCukurTableAdapter tukangCukurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalkerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengalamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTkgCukurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource1;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource3;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource2;
        private System.Windows.Forms.BindingSource tukangCukurBindingSource4;
    }
}