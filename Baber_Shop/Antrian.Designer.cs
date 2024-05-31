namespace Baber_Shop
{
    partial class Antrian
    {
        private System.Windows.Forms.DataGridView antrianDataGridView;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox queueNumberTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;

        private void InitializeComponent()
        {
            this.antrianDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.queueNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();

            // 
            // antrianDataGridView
            // 
            this.antrianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antrianDataGridView.Location = new System.Drawing.Point(12, 12);
            this.antrianDataGridView.Name = "antrianDataGridView";
            this.antrianDataGridView.Size = new System.Drawing.Size(776, 150);
            this.antrianDataGridView.TabIndex = 0;

            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(12, 180);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIdTextBox.TabIndex = 1;

            // 
            // queueNumberTextBox
            // 
            this.queueNumberTextBox.Location = new System.Drawing.Point(12, 220);
            this.queueNumberTextBox.Name = "queueNumberTextBox";
            this.queueNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.queueNumberTextBox.TabIndex = 2;

            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(12, 260);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 3;

            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Click);

            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(100, 300);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.Delete_Click);

            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(190, 300);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.Update_Click);

            // 
            // Antrian
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.antrianDataGridView);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.queueNumberTextBox);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Name = "Antrian";
            this.Load += new System.EventHandler(this.Antrian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antrianDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
