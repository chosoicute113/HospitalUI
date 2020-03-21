using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staff_ne
{
    public partial class CreateNewStaff : Form
    {
        public string GetID { get; set; }
        public string SendID { get; set; }
        public string StaffName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }        
        public CreateNewStaff()
        {
            InitializeComponent();
            
        }
        public bool Checkinfo()
        {
            if (string.IsNullOrEmpty(StaffNameTextBox.Text) ||
                       string.IsNullOrEmpty(StaffPhoneNumberTextBox.Text) || string.IsNullOrEmpty(StaffAddressTextBox.Text)
                       || string.IsNullOrEmpty(StaffAgeTextBox.Text) || !(MaleRadioButton.Checked || FemaleRadioButton.Checked))
            {
                MessageBox.Show("Missing information");
                return false;
            }
            return true;

        }

        public void StaffCreateButton_Click(object sender, EventArgs e)
        {
            if(Checkinfo())
            {
                SendID = GetID;
                StaffName = StaffNameTextBox.Text;
                PhoneNumber = Convert.ToInt32(StaffPhoneNumberTextBox.Text);
                Address = StaffAddressTextBox.Text;
                Age = Convert.ToInt32(StaffAgeTextBox.Text);
                if (MaleRadioButton.Checked)
                { Gender = "Male"; }
                else
                { Gender = "Female"; }
                Close();
            }
            

        }

        private void StaffPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }

        private void StaffAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }

        private void CreateNewStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
