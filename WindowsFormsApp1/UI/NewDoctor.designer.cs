namespace staff_ne
{
    partial class CreateNewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewStaff));
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.StaffAgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.StaffAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.StaffPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StaffNameTextBox = new System.Windows.Forms.TextBox();
            this.StaffCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(323, 236);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleRadioButton.TabIndex = 54;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(247, 236);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleRadioButton.TabIndex = 53;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(128, 239);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(57, 18);
            this.GenderLabel.TabIndex = 49;
            this.GenderLabel.Text = "Gender";
            // 
            // StaffAgeTextBox
            // 
            this.StaffAgeTextBox.Location = new System.Drawing.Point(239, 200);
            this.StaffAgeTextBox.Name = "StaffAgeTextBox";
            this.StaffAgeTextBox.Size = new System.Drawing.Size(284, 22);
            this.StaffAgeTextBox.TabIndex = 48;
            this.StaffAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffAgeTextBox_KeyPress);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(128, 201);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 18);
            this.AgeLabel.TabIndex = 47;
            this.AgeLabel.Text = "Age";
            // 
            // StaffAddressTextBox
            // 
            this.StaffAddressTextBox.Location = new System.Drawing.Point(239, 162);
            this.StaffAddressTextBox.Name = "StaffAddressTextBox";
            this.StaffAddressTextBox.Size = new System.Drawing.Size(284, 22);
            this.StaffAddressTextBox.TabIndex = 46;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(128, 163);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(62, 18);
            this.AddressLabel.TabIndex = 45;
            this.AddressLabel.Text = "Address";
            // 
            // StaffPhoneNumberTextBox
            // 
            this.StaffPhoneNumberTextBox.Location = new System.Drawing.Point(239, 124);
            this.StaffPhoneNumberTextBox.Name = "StaffPhoneNumberTextBox";
            this.StaffPhoneNumberTextBox.Size = new System.Drawing.Size(284, 22);
            this.StaffPhoneNumberTextBox.TabIndex = 44;
            this.StaffPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffPhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(128, 125);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(105, 18);
            this.PhoneNumberLabel.TabIndex = 43;
            this.PhoneNumberLabel.Text = "Phone number";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(128, 84);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 42;
            this.NameLabel.Text = "Name";
            // 
            // StaffNameTextBox
            // 
            this.StaffNameTextBox.Location = new System.Drawing.Point(239, 80);
            this.StaffNameTextBox.Name = "StaffNameTextBox";
            this.StaffNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.StaffNameTextBox.TabIndex = 41;
            // 
            // StaffCreateButton
            // 
            this.StaffCreateButton.Location = new System.Drawing.Point(277, 277);
            this.StaffCreateButton.Name = "StaffCreateButton";
            this.StaffCreateButton.Size = new System.Drawing.Size(142, 44);
            this.StaffCreateButton.TabIndex = 55;
            this.StaffCreateButton.Text = "Create";
            this.StaffCreateButton.UseVisualStyleBackColor = true;
            this.StaffCreateButton.Click += new System.EventHandler(this.StaffCreateButton_Click);
            // 
            // CreateNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 369);
            this.Controls.Add(this.StaffCreateButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
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
            this.Name = "CreateNewStaff";
            this.Text = "Create doctor";
            this.Load += new System.EventHandler(this.CreateNewStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox StaffAgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox StaffAddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox StaffPhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox StaffNameTextBox;
        private System.Windows.Forms.Button StaffCreateButton;
    }
}