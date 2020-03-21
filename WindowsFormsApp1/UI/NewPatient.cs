using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewPatient : Form
    {
        public string Gender;
        public string NewPatientName { get; set; }
        public string NewPatientPhone { get; set; }
        public string NewPatientAge { get; set; }
        public string NewPatientRoom { get; set; }
        public string NewPatientAddress { get; set; }
        public string NewPatientGender { get; set; }
        //public string ID = string.Format(string.Format("{0:0000}",PatientInterface.Patientid));
        public string sendID { get; set; }

        public NewPatient()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }

        


        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }


        public bool Checkinfo()
        {
            if (string.IsNullOrEmpty(PatientNameTextBox.Text) ||
                       string.IsNullOrEmpty(PatientPhoneNumberTextBox.Text) || string.IsNullOrEmpty(PatientRoomTextBox.Text)
                       || string.IsNullOrEmpty(PatientRoomTextBox.Text) || !(MaleRadioButton.Checked||FemaleRadioButton.Checked))
            {
                MessageBox.Show("Missing information");
                return false;
            }
            return true;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        { 
            if (Checkinfo())
            {
                NewPatientName = PatientNameTextBox.Text;
                NewPatientAddress = PatientAddressTextBox.Text;
                NewPatientAge = PatientAgeTextBox.Text;
                NewPatientPhone = PatientPhoneNumberTextBox.Text;
                NewPatientRoom = PatientRoomTextBox.Text;
                NewPatientGender = Gender;
                this.Close();
            }
        }

        private void PatientPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if(!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }

        private void PatientAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }

        private void PatientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
