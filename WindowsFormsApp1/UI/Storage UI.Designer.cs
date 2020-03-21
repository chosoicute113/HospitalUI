namespace WindowsFormsApp1
{
    partial class Storage_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage_UI));
            this.StorageItemComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StorageItemAdd = new System.Windows.Forms.LinkLabel();
            this.DeleteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EditLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StorageListView = new System.Windows.Forms.ListView();
            this.IdHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpirationdateHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackMenuButton = new System.Windows.Forms.Button();
            this.EditQtyTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeQuantityLabel = new System.Windows.Forms.Label();
            this.EditGroupbox = new System.Windows.Forms.GroupBox();
            this.EditGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StorageItemComboBox
            // 
            this.StorageItemComboBox.BackColor = System.Drawing.Color.White;
            this.StorageItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StorageItemComboBox.ForeColor = System.Drawing.Color.Black;
            this.StorageItemComboBox.FormattingEnabled = true;
            this.StorageItemComboBox.Location = new System.Drawing.Point(99, 63);
            this.StorageItemComboBox.Name = "StorageItemComboBox";
            this.StorageItemComboBox.Size = new System.Drawing.Size(166, 24);
            this.StorageItemComboBox.TabIndex = 0;
            this.StorageItemComboBox.SelectedIndexChanged += new System.EventHandler(this.StorageItemComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select item:";
            // 
            // StorageItemAdd
            // 
            this.StorageItemAdd.AutoSize = true;
            this.StorageItemAdd.Location = new System.Drawing.Point(472, 66);
            this.StorageItemAdd.Name = "StorageItemAdd";
            this.StorageItemAdd.Size = new System.Drawing.Size(33, 17);
            this.StorageItemAdd.TabIndex = 3;
            this.StorageItemAdd.TabStop = true;
            this.StorageItemAdd.Text = "Add";
            this.StorageItemAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StorageItemAdd_LinkClicked);
            // 
            // DeleteLinkLabel
            // 
            this.DeleteLinkLabel.AutoSize = true;
            this.DeleteLinkLabel.Location = new System.Drawing.Point(549, 66);
            this.DeleteLinkLabel.Name = "DeleteLinkLabel";
            this.DeleteLinkLabel.Size = new System.Drawing.Size(49, 17);
            this.DeleteLinkLabel.TabIndex = 4;
            this.DeleteLinkLabel.TabStop = true;
            this.DeleteLinkLabel.Text = "Delete";
            this.DeleteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLinkLabel_LinkClicked);
            // 
            // EditLinkLabel
            // 
            this.EditLinkLabel.AutoSize = true;
            this.EditLinkLabel.Location = new System.Drawing.Point(511, 66);
            this.EditLinkLabel.Name = "EditLinkLabel";
            this.EditLinkLabel.Size = new System.Drawing.Size(32, 17);
            this.EditLinkLabel.TabIndex = 5;
            this.EditLinkLabel.TabStop = true;
            this.EditLinkLabel.Text = "Edit";
            this.EditLinkLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditLinkLabel_MouseClick);
            // 
            // StorageListView
            // 
            this.StorageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeading,
            this.NameHeading,
            this.QuantityHeading,
            this.ExpirationdateHeading});
            this.StorageListView.FullRowSelect = true;
            this.StorageListView.GridLines = true;
            this.StorageListView.HideSelection = false;
            this.StorageListView.Location = new System.Drawing.Point(13, 100);
            this.StorageListView.Name = "StorageListView";
            this.StorageListView.Size = new System.Drawing.Size(585, 470);
            this.StorageListView.TabIndex = 6;
            this.StorageListView.UseCompatibleStateImageBehavior = false;
            this.StorageListView.View = System.Windows.Forms.View.Details;
            this.StorageListView.SelectedIndexChanged += new System.EventHandler(this.StorageListView_SelectedIndexChanged);
            // 
            // IdHeading
            // 
            this.IdHeading.Text = "ID";
            // 
            // NameHeading
            // 
            this.NameHeading.Text = "Name";
            this.NameHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameHeading.Width = 226;
            // 
            // QuantityHeading
            // 
            this.QuantityHeading.Text = "Quantity";
            this.QuantityHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityHeading.Width = 89;
            // 
            // ExpirationdateHeading
            // 
            this.ExpirationdateHeading.Text = "Expiration date";
            this.ExpirationdateHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExpirationdateHeading.Width = 206;
            // 
            // BackMenuButton
            // 
            this.BackMenuButton.Location = new System.Drawing.Point(12, 12);
            this.BackMenuButton.Name = "BackMenuButton";
            this.BackMenuButton.Size = new System.Drawing.Size(75, 39);
            this.BackMenuButton.TabIndex = 27;
            this.BackMenuButton.Text = "Back";
            this.BackMenuButton.UseVisualStyleBackColor = true;
            this.BackMenuButton.Click += new System.EventHandler(this.BackMenuButton_Click);
            // 
            // EditQtyTextBox
            // 
            this.EditQtyTextBox.Location = new System.Drawing.Point(78, 19);
            this.EditQtyTextBox.Name = "EditQtyTextBox";
            this.EditQtyTextBox.Size = new System.Drawing.Size(100, 22);
            this.EditQtyTextBox.TabIndex = 28;
            this.EditQtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditQtyTextBox_KeyPress);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(184, 18);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 29;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeQuantityLabel
            // 
            this.ChangeQuantityLabel.AutoSize = true;
            this.ChangeQuantityLabel.Location = new System.Drawing.Point(11, 22);
            this.ChangeQuantityLabel.Name = "ChangeQuantityLabel";
            this.ChangeQuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.ChangeQuantityLabel.TabIndex = 30;
            this.ChangeQuantityLabel.Text = "Quantity";
            // 
            // EditGroupbox
            // 
            this.EditGroupbox.Controls.Add(this.ChangeQuantityLabel);
            this.EditGroupbox.Controls.Add(this.ChangeButton);
            this.EditGroupbox.Controls.Add(this.EditQtyTextBox);
            this.EditGroupbox.Location = new System.Drawing.Point(283, 12);
            this.EditGroupbox.Name = "EditGroupbox";
            this.EditGroupbox.Size = new System.Drawing.Size(280, 51);
            this.EditGroupbox.TabIndex = 31;
            this.EditGroupbox.TabStop = false;
            this.EditGroupbox.Text = "Edit";
            // 
            // Storage_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 582);
            this.Controls.Add(this.EditGroupbox);
            this.Controls.Add(this.BackMenuButton);
            this.Controls.Add(this.StorageListView);
            this.Controls.Add(this.EditLinkLabel);
            this.Controls.Add(this.DeleteLinkLabel);
            this.Controls.Add(this.StorageItemAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StorageItemComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storage_UI";
            this.Text = "Storage_UI";
            this.Load += new System.EventHandler(this.Storage_UI_Load);
            this.EditGroupbox.ResumeLayout(false);
            this.EditGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StorageItemComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel StorageItemAdd;
        private System.Windows.Forms.LinkLabel DeleteLinkLabel;
        private System.Windows.Forms.LinkLabel EditLinkLabel;
        private System.Windows.Forms.ListView StorageListView;
        private System.Windows.Forms.ColumnHeader IdHeading;
        private System.Windows.Forms.ColumnHeader NameHeading;
        private System.Windows.Forms.ColumnHeader QuantityHeading;
        private System.Windows.Forms.ColumnHeader ExpirationdateHeading;
        private System.Windows.Forms.Button BackMenuButton;
        private System.Windows.Forms.TextBox EditQtyTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label ChangeQuantityLabel;
        private System.Windows.Forms.GroupBox EditGroupbox;
    }
}