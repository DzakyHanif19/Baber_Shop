namespace Baber_Shop
{
    partial class Pembookingan
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
            this.barberShopDataSet = new Baber_Shop.BarberShopDataSet();
            this.pembookinganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembookinganTableAdapter = new Baber_Shop.BarberShopDataSetTableAdapters.PembookinganTableAdapter();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.bookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktubookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noantrianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTkgCukurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembookinganBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pembookinganBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pembookinganBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pembookinganBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pembookinganBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // barberShopDataSet
            // 
            this.barberShopDataSet.DataSetName = "BarberShopDataSet";
            this.barberShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembookinganBindingSource
            // 
            this.pembookinganBindingSource.DataMember = "Pembookingan";
            this.pembookinganBindingSource.DataSource = this.barberShopDataSet;
            // 
            // pembookinganTableAdapter
            // 
            this.pembookinganTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource5, "No_antrian", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(5, 178);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(269, 22);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // bookingDateTimePicker
            // 
            this.bookingDateTimePicker.Location = new System.Drawing.Point(5, 224);
            this.bookingDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.bookingDateTimePicker.Name = "bookingDateTimePicker";
            this.bookingDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.bookingDateTimePicker.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 289);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(111, 289);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(219, 289);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource2, "Nama_pelanggan", true));
            this.textBox1.Location = new System.Drawing.Point(9, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource4, "Waktu_booking", true));
            this.textBox2.Location = new System.Drawing.Point(5, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nomor Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookingDataGridViewTextBoxColumn,
            this.namapelangganDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.waktubookingDataGridViewTextBoxColumn,
            this.noantrianDataGridViewTextBoxColumn,
            this.idPelangganDataGridViewTextBoxColumn,
            this.idTkgCukurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pembookinganBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(386, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // idbookingDataGridViewTextBoxColumn
            // 
            this.idbookingDataGridViewTextBoxColumn.DataPropertyName = "Id_booking";
            this.idbookingDataGridViewTextBoxColumn.HeaderText = "Id_booking";
            this.idbookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbookingDataGridViewTextBoxColumn.Name = "idbookingDataGridViewTextBoxColumn";
            this.idbookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // namapelangganDataGridViewTextBoxColumn
            // 
            this.namapelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.HeaderText = "Nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapelangganDataGridViewTextBoxColumn.Name = "namapelangganDataGridViewTextBoxColumn";
            this.namapelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "No_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "No_telp";
            this.notelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // waktubookingDataGridViewTextBoxColumn
            // 
            this.waktubookingDataGridViewTextBoxColumn.DataPropertyName = "Waktu_booking";
            this.waktubookingDataGridViewTextBoxColumn.HeaderText = "Waktu_booking";
            this.waktubookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktubookingDataGridViewTextBoxColumn.Name = "waktubookingDataGridViewTextBoxColumn";
            this.waktubookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // noantrianDataGridViewTextBoxColumn
            // 
            this.noantrianDataGridViewTextBoxColumn.DataPropertyName = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.HeaderText = "No_antrian";
            this.noantrianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noantrianDataGridViewTextBoxColumn.Name = "noantrianDataGridViewTextBoxColumn";
            this.noantrianDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPelangganDataGridViewTextBoxColumn
            // 
            this.idPelangganDataGridViewTextBoxColumn.DataPropertyName = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.HeaderText = "idPelanggan";
            this.idPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPelangganDataGridViewTextBoxColumn.Name = "idPelangganDataGridViewTextBoxColumn";
            this.idPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTkgCukurDataGridViewTextBoxColumn
            // 
            this.idTkgCukurDataGridViewTextBoxColumn.DataPropertyName = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.HeaderText = "Id_TkgCukur";
            this.idTkgCukurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTkgCukurDataGridViewTextBoxColumn.Name = "idTkgCukurDataGridViewTextBoxColumn";
            this.idTkgCukurDataGridViewTextBoxColumn.Width = 125;
            // 
            // pembookinganBindingSource1
            // 
            this.pembookinganBindingSource1.DataMember = "Pembookingan";
            this.pembookinganBindingSource1.DataSource = this.barberShopDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Waktu Booking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembookinganBindingSource3, "No_telp", true));
            this.textBox3.Location = new System.Drawing.Point(5, 90);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nomor Antrian";
            // 
            // pembookinganBindingSource2
            // 
            this.pembookinganBindingSource2.DataMember = "Pembookingan";
            this.pembookinganBindingSource2.DataSource = this.barberShopDataSet;
            // 
            // pembookinganBindingSource3
            // 
            this.pembookinganBindingSource3.DataMember = "Pembookingan";
            this.pembookinganBindingSource3.DataSource = this.barberShopDataSet;
            // 
            // pembookinganBindingSource4
            // 
            this.pembookinganBindingSource4.DataMember = "Pembookingan";
            this.pembookinganBindingSource4.DataSource = this.barberShopDataSet;
            // 
            // pembookinganBindingSource5
            // 
            this.pembookinganBindingSource5.DataMember = "Pembookingan";
            this.pembookinganBindingSource5.DataSource = this.barberShopDataSet;
            // 
            // Pembookingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 359);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookingDateTimePicker);
            this.Controls.Add(this.customerNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pembookingan";
            this.Text = "Pembookingan";
            this.Load += new System.EventHandler(this.Pembookingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barberShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembookinganBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource pembookinganBindingSource;
        private BarberShopDataSetTableAdapters.PembookinganTableAdapter pembookinganTableAdapter;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DateTimePicker bookingDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktubookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTkgCukurDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pembookinganBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource pembookinganBindingSource5;
        private System.Windows.Forms.BindingSource pembookinganBindingSource2;
        private System.Windows.Forms.BindingSource pembookinganBindingSource4;
        private System.Windows.Forms.BindingSource pembookinganBindingSource3;
    }
}
