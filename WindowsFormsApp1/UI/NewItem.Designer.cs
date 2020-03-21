namespace WindowsFormsApp1.UI
{
    partial class NewItem
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.ItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FandWComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(166, 371);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(87, 34);
            this.CreateButton.TabIndex = 55;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(11, 214);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(105, 18);
            this.ExpirationDateLabel.TabIndex = 46;
            this.ExpirationDateLabel.Text = "Expiration date";
            // 
            // ItemQuantityTextBox
            // 
            this.ItemQuantityTextBox.Location = new System.Drawing.Point(122, 141);
            this.ItemQuantityTextBox.Name = "ItemQuantityTextBox";
            this.ItemQuantityTextBox.Size = new System.Drawing.Size(235, 22);
            this.ItemQuantityTextBox.TabIndex = 45;
            this.ItemQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemQuantityTextBox_KeyPress);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(11, 141);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(62, 18);
            this.QuantityLabel.TabIndex = 44;
            this.QuantityLabel.Text = "Quantity";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(11, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 43;
            this.NameLabel.Text = "Name";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(122, 96);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(235, 22);
            this.ItemNameTextBox.TabIndex = 42;
            // 
            // ItemDateTimePicker
            // 
            this.ItemDateTimePicker.CustomFormat = "";
            this.ItemDateTimePicker.Location = new System.Drawing.Point(122, 214);
            this.ItemDateTimePicker.Name = "ItemDateTimePicker";
            this.ItemDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.ItemDateTimePicker.TabIndex = 56;
            this.ItemDateTimePicker.Value = new System.DateTime(2020, 3, 17, 18, 11, 40, 0);
            this.ItemDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FandWComboBox
            // 
            this.FandWComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FandWComboBox.FormattingEnabled = true;
            this.FandWComboBox.Location = new System.Drawing.Point(259, 170);
            this.FandWComboBox.Name = "FandWComboBox";
            this.FandWComboBox.Size = new System.Drawing.Size(98, 24);
            this.FandWComboBox.TabIndex = 57;
            this.FandWComboBox.SelectedIndexChanged += new System.EventHandler(this.FandWComboBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(209, 170);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(44, 18);
            this.TypeLabel.TabIndex = 58;
            this.TypeLabel.Text = "Type:";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.FandWComboBox);
            this.Controls.Add(this.ItemDateTimePicker);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.ItemQuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ItemNameTextBox);
            this.Name = "NewItem";
            this.Text = "AddItemToStorage";
            this.Load += new System.EventHandler(this.AddItemToStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.TextBox ItemQuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.DateTimePicker ItemDateTimePicker;
        private System.Windows.Forms.ComboBox FandWComboBox;
        private System.Windows.Forms.Label TypeLabel;
    }
}