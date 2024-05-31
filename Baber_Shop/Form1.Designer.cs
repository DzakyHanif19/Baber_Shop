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
            this.antrianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // antrianBindingSource
            // 
            this.antrianBindingSource.DataMember = "Antrian";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(210, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "Antrian";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Antrian_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "Pembookingan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Pembookingan_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(210, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "Tukang Cukur";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.TukangCukur_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(210, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "Pelanggan";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Pelanggan_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1037, 300);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Name = "Form1";
            this.Text = "Barber Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antrianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        //private BarberShopDataSet barberShopDataSet;
        private System.Windows.Forms.BindingSource antrianBindingSource;
        //private BarberShopDataSetTableAdapters.AntrianTableAdapter antrianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktutungguDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idantrianDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

