namespace WindowsFormsApp1
{
    partial class PatientInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInterface));
            this.PatientListLabel = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PatientPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PatientAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PatientAgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.PatientIDTextbox = new System.Windows.Forms.TextBox();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.DeletePatientLabel = new System.Windows.Forms.LinkLabel();
            this.PatientRoomTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.PatientListView = new System.Windows.Forms.ListView();
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientCreateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BackMenuButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatientListLabel
            // 
            this.PatientListLabel.AutoSize = true;
            this.PatientListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListLabel.ForeColor = System.Drawing.Color.Blue;
            this.PatientListLabel.Location = new System.Drawing.Point(424, 22);
            this.PatientListLabel.Name = "PatientListLabel";
            this.PatientListLabel.Size = new System.Drawing.Size(135, 29);
            this.PatientListLabel.TabIndex = 1;
            this.PatientListLabel.Text = "Patient list";
            this.PatientListLabel.Click += new System.EventHandler(this.PatientListLabel_Click);
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(147, 123);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.PatientNameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(36, 127);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // PatientPhoneNumberTextBox
            // 
            this.PatientPhoneNumberTextBox.Location = new System.Drawing.Point(147, 202);
            this.PatientPhoneNumberTextBox.Name = "PatientPhoneNumberTextBox";
            this.PatientPhoneNumberTextBox.Size = new System.Drawing.Size(284, 22);
            this.PatientPhoneNumberTextBox.TabIndex = 8;
            this.PatientPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientPhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(36, 202);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(105, 18);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "Phone number";
            // 
            // PatientAddressTextBox
            // 
            this.PatientAddressTextBox.Location = new System.Drawing.Point(593, 91);
            this.PatientAddressTextBox.Name = "PatientAddressTextBox";
            this.PatientAddressTextBox.Size = new System.Drawing.Size(284, 22);
            this.PatientAddressTextBox.TabIndex = 10;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(482, 92);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(62, 18);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address";
            // 
            // PatientAgeTextBox
            // 
            this.PatientAgeTextBox.Location = new System.Drawing.Point(593, 127);
            this.PatientAgeTextBox.Name = "PatientAgeTextBox";
            this.PatientAgeTextBox.Size = new System.Drawing.Size(284, 22);
            this.PatientAgeTextBox.TabIndex = 12;
            this.PatientAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientAgeTextBox_KeyPress);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(482, 130);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 18);
            this.AgeLabel.TabIndex = 11;
            this.AgeLabel.Text = "Age";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(482, 168);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(57, 18);
            this.GenderLabel.TabIndex = 13;
            this.GenderLabel.Text = "Gender";
            // 
            // PatientIDTextbox
            // 
            this.PatientIDTextbox.Enabled = false;
            this.PatientIDTextbox.Location = new System.Drawing.Point(147, 87);
            this.PatientIDTextbox.Name = "PatientIDTextbox";
            this.PatientIDTextbox.Size = new System.Drawing.Size(284, 22);
            this.PatientIDTextbox.TabIndex = 16;
            // 
            // PatientLabel
            // 
            this.PatientLabel.AutoSize = true;
            this.PatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientLabel.Location = new System.Drawing.Point(36, 88);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(71, 18);
            this.PatientLabel.TabIndex = 15;
            this.PatientLabel.Text = "Patient ID";
            // 
            // DeletePatientLabel
            // 
            this.DeletePatientLabel.AutoSize = true;
            this.DeletePatientLabel.Location = new System.Drawing.Point(382, 263);
            this.DeletePatientLabel.Name = "DeletePatientLabel";
            this.DeletePatientLabel.Size = new System.Drawing.Size(49, 17);
            this.DeletePatientLabel.TabIndex = 18;
            this.DeletePatientLabel.TabStop = true;
            this.DeletePatientLabel.Text = "Delete";
            this.DeletePatientLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeletePatientLabel_LinkClicked);
            // 
            // PatientRoomTextBox
            // 
            this.PatientRoomTextBox.Location = new System.Drawing.Point(147, 162);
            this.PatientRoomTextBox.Name = "PatientRoomTextBox";
            this.PatientRoomTextBox.Size = new System.Drawing.Size(284, 22);
            this.PatientRoomTextBox.TabIndex = 20;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLabel.Location = new System.Drawing.Point(36, 168);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(50, 18);
            this.RoomLabel.TabIndex = 19;
            this.RoomLabel.Text = "Room";
            // 
            // PatientListView
            // 
            this.PatientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.PatientName,
            this.PatientRoom,
            this.PatientPhone,
            this.PatientAddress,
            this.PatientAge,
            this.PatientGender});
            this.PatientListView.FullRowSelect = true;
            this.PatientListView.GridLines = true;
            this.PatientListView.HideSelection = false;
            this.PatientListView.Location = new System.Drawing.Point(12, 296);
            this.PatientListView.MultiSelect = false;
            this.PatientListView.Name = "PatientListView";
            this.PatientListView.Size = new System.Drawing.Size(967, 273);
            this.PatientListView.TabIndex = 21;
            this.PatientListView.UseCompatibleStateImageBehavior = false;
            this.PatientListView.View = System.Windows.Forms.View.Details;
            this.PatientListView.SelectedIndexChanged += new System.EventHandler(this.PatientListView_SelectedIndexChanged);
            this.PatientListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PatientListView_MouseClick);
            this.PatientListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PatientListView_MouseClick);
            // 
            // PatientID
            // 
            this.PatientID.Text = "ID";
            this.PatientID.Width = 50;
            // 
            // PatientName
            // 
            this.PatientName.Text = "Name";
            this.PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientName.Width = 313;
            // 
            // PatientRoom
            // 
            this.PatientRoom.Text = "Room";
            this.PatientRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientRoom.Width = 68;
            // 
            // PatientPhone
            // 
            this.PatientPhone.Text = "Phone";
            this.PatientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientPhone.Width = 163;
            // 
            // PatientAddress
            // 
            this.PatientAddress.Text = "Address";
            this.PatientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientAddress.Width = 248;
            // 
            // PatientAge
            // 
            this.PatientAge.Text = "Age";
            this.PatientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientGender
            // 
            this.PatientGender.Text = "Gender";
            this.PatientGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientCreateLinkLabel
            // 
            this.PatientCreateLinkLabel.AutoSize = true;
            this.PatientCreateLinkLabel.Location = new System.Drawing.Point(271, 263);
            this.PatientCreateLinkLabel.Name = "PatientCreateLinkLabel";
            this.PatientCreateLinkLabel.Size = new System.Drawing.Size(79, 17);
            this.PatientCreateLinkLabel.TabIndex = 22;
            this.PatientCreateLinkLabel.TabStop = true;
            this.PatientCreateLinkLabel.Text = "Create new";
            this.PatientCreateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PatientCreateLinkLabel_LinkClicked);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(593, 168);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleRadioButton.TabIndex = 23;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(669, 168);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleRadioButton.TabIndex = 24;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(802, 201);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BackMenuButton
            // 
            this.BackMenuButton.Location = new System.Drawing.Point(11, 12);
            this.BackMenuButton.Name = "BackMenuButton";
            this.BackMenuButton.Size = new System.Drawing.Size(75, 39);
            this.BackMenuButton.TabIndex = 26;
            this.BackMenuButton.Text = "Back";
            this.BackMenuButton.UseVisualStyleBackColor = true;
            this.BackMenuButton.Click += new System.EventHandler(this.BackMenuButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(547, 263);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(330, 22);
            this.SearchBox.TabIndex = 27;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(482, 263);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(59, 18);
            this.SearchLabel.TabIndex = 28;
            this.SearchLabel.Text = "Search:";
            // 
            // PatientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 581);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.BackMenuButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.PatientCreateLinkLabel);
            this.Controls.Add(this.PatientListView);
            this.Controls.Add(this.PatientRoomTextBox);
            this.Controls.Add(this.RoomLabel);
            this.Controls.Add(this.DeletePatientLabel);
            this.Controls.Add(this.PatientIDTextbox);
            this.Controls.Add(this.PatientLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PatientAgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.PatientAddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PatientPhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.PatientListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientInterface";
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.PatientInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PatientListLabel;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PatientPhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PatientAddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox PatientAgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox PatientIDTextbox;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.LinkLabel DeletePatientLabel;
        private System.Windows.Forms.TextBox PatientRoomTextBox;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ListView PatientListView;
        private System.Windows.Forms.ColumnHeader PatientID;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader PatientRoom;
        private System.Windows.Forms.LinkLabel PatientCreateLinkLabel;
        private System.Windows.Forms.ColumnHeader PatientPhone;
        private System.Windows.Forms.ColumnHeader PatientAddress;
        private System.Windows.Forms.ColumnHeader PatientAge;
        private System.Windows.Forms.ColumnHeader PatientGender;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button BackMenuButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}