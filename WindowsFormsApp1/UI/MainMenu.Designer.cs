namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PatientListButton = new System.Windows.Forms.Button();
            this.StaffListButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientListButton
            // 
            this.PatientListButton.BackColor = System.Drawing.Color.White;
            this.PatientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListButton.Location = new System.Drawing.Point(219, 53);
            this.PatientListButton.Name = "PatientListButton";
            this.PatientListButton.Size = new System.Drawing.Size(278, 43);
            this.PatientListButton.TabIndex = 0;
            this.PatientListButton.Text = "Patient list";
            this.PatientListButton.UseVisualStyleBackColor = false;
            this.PatientListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffListButton
            // 
            this.StaffListButton.BackColor = System.Drawing.Color.White;
            this.StaffListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffListButton.Location = new System.Drawing.Point(219, 123);
            this.StaffListButton.Name = "StaffListButton";
            this.StaffListButton.Size = new System.Drawing.Size(278, 47);
            this.StaffListButton.TabIndex = 1;
            this.StaffListButton.Text = "Doctor list";
            this.StaffListButton.UseVisualStyleBackColor = false;
            this.StaffListButton.Click += new System.EventHandler(this.StaffListButton_Click);
            // 
            // StorageButton
            // 
            this.StorageButton.BackColor = System.Drawing.Color.White;
            this.StorageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageButton.Location = new System.Drawing.Point(219, 194);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(278, 46);
            this.StorageButton.TabIndex = 2;
            this.StorageButton.Text = "Storage";
            this.StorageButton.UseVisualStyleBackColor = false;
            this.StorageButton.Click += new System.EventHandler(this.Storage_button_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.White;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.Location = new System.Drawing.Point(219, 266);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(278, 47);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(219, 421);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(278, 47);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(724, 512);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.StaffListButton);
            this.Controls.Add(this.PatientListButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Hospital management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PatientListButton;
        private System.Windows.Forms.Button StaffListButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

