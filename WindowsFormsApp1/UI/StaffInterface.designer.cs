namespace staff_ne
{
    partial class StafttInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StafttInterface));
            this.Label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.StaffListView = new System.Windows.Forms.ListView();
            this.StaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteStaffLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StaffIDTextbox = new System.Windows.Forms.TextBox();
            this.StaffLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.StaffAgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.StaffAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.StaffPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StaffNameTextBox = new System.Windows.Forms.TextBox();
            this.StaffCreateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BackMenuButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(441, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 29);
            this.Label1.TabIndex = 65;
            this.Label1.Text = "Doctor list";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(830, 185);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(69, 30);
            this.UpdateButton.TabIndex = 64;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(697, 147);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleRadioButton.TabIndex = 63;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(621, 147);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleRadioButton.TabIndex = 62;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // StaffListView
            // 
            this.StaffListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StaffID,
            this.StaffName,
            this.StaffPhone,
            this.StaffAddress,
            this.StaffAge,
            this.StaffGender});
            this.StaffListView.FullRowSelect = true;
            this.StaffListView.GridLines = true;
            this.StaffListView.HideSelection = false;
            this.StaffListView.Location = new System.Drawing.Point(12, 263);
            this.StaffListView.MultiSelect = false;
            this.StaffListView.Name = "StaffListView";
            this.StaffListView.Size = new System.Drawing.Size(968, 256);
            this.StaffListView.TabIndex = 60;
            this.StaffListView.UseCompatibleStateImageBehavior = false;
            this.StaffListView.View = System.Windows.Forms.View.Details;
            this.StaffListView.SelectedIndexChanged += new System.EventHandler(this.StaffListView_SelectedIndexChanged);
            this.StaffListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StaffListView_MouseClick);
            this.StaffListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StaffListView_MouseClick);
            // 
            // StaffID
            // 
            this.StaffID.Text = "ID";
            this.StaffID.Width = 50;
            // 
            // StaffName
            // 
            this.StaffName.Text = "Name";
            this.StaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffName.Width = 383;
            // 
            // StaffPhone
            // 
            this.StaffPhone.Text = "Phone";
            this.StaffPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffPhone.Width = 163;
            // 
            // StaffAddress
            // 
            this.StaffAddress.Text = "Address";
            this.StaffAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffAddress.Width = 248;
            // 
            // StaffAge
            // 
            this.StaffAge.Text = "Age";
            this.StaffAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StaffGender
            // 
            this.StaffGender.Text = "Gender";
            this.StaffGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteStaffLinkLabel
            // 
            this.DeleteStaffLinkLabel.AutoSize = true;
            this.DeleteStaffLinkLabel.Location = new System.Drawing.Point(414, 229);
            this.DeleteStaffLinkLabel.Name = "DeleteStaffLinkLabel";
            this.DeleteStaffLinkLabel.Size = new System.Drawing.Size(49, 17);
            this.DeleteStaffLinkLabel.TabIndex = 57;
            this.DeleteStaffLinkLabel.TabStop = true;
            this.DeleteStaffLinkLabel.Text = "Delete";
            this.DeleteStaffLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteStaffLinkLabel_LinkClicked);
            // 
            // StaffIDTextbox
            // 
            this.StaffIDTextbox.Enabled = false;
            this.StaffIDTextbox.Location = new System.Drawing.Point(175, 66);
            this.StaffIDTextbox.Name = "StaffIDTextbox";
            this.StaffIDTextbox.Size = new System.Drawing.Size(278, 22);
            this.StaffIDTextbox.TabIndex = 56;
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLabel.Location = new System.Drawing.Point(64, 67);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(56, 18);
            this.StaffLabel.TabIndex = 55;
            this.StaffLabel.Text = "Staff ID";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(510, 147);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(57, 18);
            this.GenderLabel.TabIndex = 54;
            this.GenderLabel.Text = "Gender";
            // 
            // StaffAgeTextBox
            // 
            this.StaffAgeTextBox.Location = new System.Drawing.Point(621, 106);
            this.StaffAgeTextBox.Name = "StaffAgeTextBox";
            this.StaffAgeTextBox.Size = new System.Drawing.Size(278, 22);
            this.StaffAgeTextBox.TabIndex = 53;
            this.StaffAgeTextBox.TextChanged += new System.EventHandler(this.StaffAgeTextBox_TextChanged);
            this.StaffAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffAgeTextBox_KeyPress);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(510, 109);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 18);
            this.AgeLabel.TabIndex = 52;
            this.AgeLabel.Text = "Age";
            // 
            // StaffAddressTextBox
            // 
            this.StaffAddressTextBox.Location = new System.Drawing.Point(621, 70);
            this.StaffAddressTextBox.Name = "StaffAddressTextBox";
            this.StaffAddressTextBox.Size = new System.Drawing.Size(278, 22);
            this.StaffAddressTextBox.TabIndex = 51;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(510, 71);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(62, 18);
            this.AddressLabel.TabIndex = 50;
            this.AddressLabel.Text = "Address";
            // 
            // StaffPhoneNumberTextBox
            // 
            this.StaffPhoneNumberTextBox.Location = new System.Drawing.Point(175, 143);
            this.StaffPhoneNumberTextBox.Name = "StaffPhoneNumberTextBox";
            this.StaffPhoneNumberTextBox.Size = new System.Drawing.Size(278, 22);
            this.StaffPhoneNumberTextBox.TabIndex = 49;
            this.StaffPhoneNumberTextBox.TextChanged += new System.EventHandler(this.StaffPhoneNumberTextBox_TextChanged);
            this.StaffPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffPhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(64, 143);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(105, 18);
            this.PhoneNumberLabel.TabIndex = 48;
            this.PhoneNumberLabel.Text = "Phone number";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(64, 106);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 47;
            this.NameLabel.Text = "Name";
            // 
            // StaffNameTextBox
            // 
            this.StaffNameTextBox.Location = new System.Drawing.Point(175, 102);
            this.StaffNameTextBox.Name = "StaffNameTextBox";
            this.StaffNameTextBox.Size = new System.Drawing.Size(278, 22);
            this.StaffNameTextBox.TabIndex = 46;
            this.StaffNameTextBox.TextChanged += new System.EventHandler(this.StaffNameTextBox_TextChanged);
            // 
            // StaffCreateLinkLabel
            // 
            this.StaffCreateLinkLabel.AutoSize = true;
            this.StaffCreateLinkLabel.Location = new System.Drawing.Point(301, 229);
            this.StaffCreateLinkLabel.Name = "StaffCreateLinkLabel";
            this.StaffCreateLinkLabel.Size = new System.Drawing.Size(79, 17);
            this.StaffCreateLinkLabel.TabIndex = 66;
            this.StaffCreateLinkLabel.TabStop = true;
            this.StaffCreateLinkLabel.Text = "Create new";
            this.StaffCreateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StaffCreateLinkLabel_LinkClicked);
            // 
            // BackMenuButton
            // 
            this.BackMenuButton.Location = new System.Drawing.Point(12, 12);
            this.BackMenuButton.Name = "BackMenuButton";
            this.BackMenuButton.Size = new System.Drawing.Size(75, 39);
            this.BackMenuButton.TabIndex = 67;
            this.BackMenuButton.Text = "Back";
            this.BackMenuButton.UseVisualStyleBackColor = true;
            this.BackMenuButton.Click += new System.EventHandler(this.BackMenuButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(192, 185);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(241, 30);
            this.SelectButton.TabIndex = 68;
            this.SelectButton.Text = "Select patients for treatment";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // StafttInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 531);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.BackMenuButton);
            this.Controls.Add(this.StaffCreateLinkLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.StaffListView);
            this.Controls.Add(this.DeleteStaffLinkLabel);
            this.Controls.Add(this.StaffIDTextbox);
            this.Controls.Add(this.StaffLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.StaffAgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.StaffAddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.StaffPhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StaffNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StafttInterface";
            this.Text = "Doctor list";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.ColumnHeader StaffID;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.ColumnHeader StaffPhone;
        private System.Windows.Forms.ColumnHeader StaffAddress;
        private System.Windows.Forms.ColumnHeader StaffAge;
        private System.Windows.Forms.ColumnHeader StaffGender;
        private System.Windows.Forms.LinkLabel DeleteStaffLinkLabel;
        private System.Windows.Forms.TextBox StaffIDTextbox;
        private System.Windows.Forms.Label StaffLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox StaffAgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox StaffAddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox StaffPhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox StaffNameTextBox;
        private System.Windows.Forms.LinkLabel StaffCreateLinkLabel;
        private System.Windows.Forms.Button BackMenuButton;
        private System.Windows.Forms.Button SelectButton;
        public System.Windows.Forms.ListView StaffListView;
    }
}

