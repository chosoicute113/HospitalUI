namespace WindowsFormsApp1.Class
{
    partial class SelectPatient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.RenoveButton = new System.Windows.Forms.Button();
            this.APListView = new System.Windows.Forms.ListView();
            this.AP_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AP_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AP_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AP_Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AP_Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AP_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AP_Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPListView = new System.Windows.Forms.ListView();
            this.SP_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP_Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP_Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SP_Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Patient list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selected patients for treatment";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(128, 224);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(111, 25);
            this.ADD.TabIndex = 15;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // RenoveButton
            // 
            this.RenoveButton.Location = new System.Drawing.Point(275, 224);
            this.RenoveButton.Name = "RenoveButton";
            this.RenoveButton.Size = new System.Drawing.Size(116, 25);
            this.RenoveButton.TabIndex = 14;
            this.RenoveButton.Text = "REMOVE";
            this.RenoveButton.UseVisualStyleBackColor = true;
            this.RenoveButton.Click += new System.EventHandler(this.RenoveButton_Click);
            // 
            // APListView
            // 
            this.APListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AP_ID,
            this.AP_Name,
            this.AP_Phone,
            this.AP_Age,
            this.AP_Room,
            this.AP_Address,
            this.AP_Gender});
            this.APListView.FullRowSelect = true;
            this.APListView.GridLines = true;
            this.APListView.HideSelection = false;
            this.APListView.Location = new System.Drawing.Point(12, 266);
            this.APListView.Name = "APListView";
            this.APListView.Size = new System.Drawing.Size(624, 172);
            this.APListView.TabIndex = 20;
            this.APListView.UseCompatibleStateImageBehavior = false;
            this.APListView.View = System.Windows.Forms.View.Details;
            this.APListView.SelectedIndexChanged += new System.EventHandler(this.APListView_SelectedIndexChanged);
            // 
            // AP_ID
            // 
            this.AP_ID.Text = "ID";
            this.AP_ID.Width = 44;
            // 
            // AP_Name
            // 
            this.AP_Name.Text = "Name";
            this.AP_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AP_Name.Width = 123;
            // 
            // AP_Phone
            // 
            this.AP_Phone.Text = "Phone";
            this.AP_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AP_Phone.Width = 148;
            // 
            // AP_Age
            // 
            this.AP_Age.Text = "Age";
            this.AP_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AP_Room
            // 
            this.AP_Room.Text = "Room";
            this.AP_Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AP_Address
            // 
            this.AP_Address.Text = "Address";
            this.AP_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AP_Address.Width = 124;
            // 
            // AP_Gender
            // 
            this.AP_Gender.Text = "Gender";
            this.AP_Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SPListView
            // 
            this.SPListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SP_ID,
            this.SP_Name,
            this.SP_Phone,
            this.SP_Age,
            this.SP_Room,
            this.SP_Address,
            this.SP_Gender});
            this.SPListView.FullRowSelect = true;
            this.SPListView.GridLines = true;
            this.SPListView.HideSelection = false;
            this.SPListView.Location = new System.Drawing.Point(14, 30);
            this.SPListView.Name = "SPListView";
            this.SPListView.Size = new System.Drawing.Size(624, 172);
            this.SPListView.TabIndex = 21;
            this.SPListView.UseCompatibleStateImageBehavior = false;
            this.SPListView.View = System.Windows.Forms.View.Details;
            // 
            // SP_ID
            // 
            this.SP_ID.Text = "ID";
            this.SP_ID.Width = 44;
            // 
            // SP_Name
            // 
            this.SP_Name.Text = "Name";
            this.SP_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SP_Name.Width = 123;
            // 
            // SP_Phone
            // 
            this.SP_Phone.Text = "Phone";
            this.SP_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SP_Phone.Width = 148;
            // 
            // SP_Age
            // 
            this.SP_Age.Text = "Age";
            this.SP_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SP_Room
            // 
            this.SP_Room.Text = "Room";
            this.SP_Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SP_Address
            // 
            this.SP_Address.Text = "Address";
            this.SP_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SP_Address.Width = 124;
            // 
            // SP_Gender
            // 
            this.SP_Gender.Text = "Gender";
            this.SP_Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(424, 224);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 25);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SPListView);
            this.Controls.Add(this.APListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.RenoveButton);
            this.Name = "SelectPatient";
            this.Text = "SelectPatient";
            this.Load += new System.EventHandler(this.SelectPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button RenoveButton;
        private System.Windows.Forms.ColumnHeader AP_ID;
        private System.Windows.Forms.ColumnHeader AP_Name;
        private System.Windows.Forms.ColumnHeader AP_Phone;
        private System.Windows.Forms.ColumnHeader AP_Age;
        private System.Windows.Forms.ColumnHeader AP_Room;
        private System.Windows.Forms.ColumnHeader AP_Address;
        private System.Windows.Forms.ColumnHeader AP_Gender;
        private System.Windows.Forms.ColumnHeader SP_ID;
        private System.Windows.Forms.ColumnHeader SP_Name;
        private System.Windows.Forms.ColumnHeader SP_Phone;
        private System.Windows.Forms.ColumnHeader SP_Age;
        private System.Windows.Forms.ColumnHeader SP_Room;
        private System.Windows.Forms.ColumnHeader SP_Address;
        private System.Windows.Forms.ColumnHeader SP_Gender;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.ListView APListView;
        public System.Windows.Forms.ListView SPListView;
    }
}