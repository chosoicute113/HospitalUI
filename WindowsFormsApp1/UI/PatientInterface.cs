using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PatientInterface : Form
    {
        public static int Patientid = 1;    //Startup ID -> NewPatient.ID to become string ( e.g. 1 -> 0001)
        public static List<Patient> PatientList = new List<Patient>();

        private void clrscreen()
        {
            PatientNameTextBox.Clear();
            PatientPhoneNumberTextBox.Clear();
            PatientIDTextbox.Clear();
            PatientAgeTextBox.Clear();
            PatientAddressTextBox.Clear();
            PatientRoomTextBox.Clear();

        }





        public PatientInterface()
        {
            int index = 0;

            InitializeComponent();

            while(PatientListView.Items.Count != PatientList.Count)
            {
                
                string[] column = new string[] {PatientList[index].PatientID,
                PatientList[index].PatientName,PatientList[index].PatientRoom,Convert.ToString(PatientList[index].PatientPhone)
                ,PatientList[index].PatientAddress,Convert.ToString(PatientList[index].PatientAge),PatientList[index].PatientGender };

                ListViewItem row = new ListViewItem(column);

                PatientListView.Items.Add(row);
                index++;
            }
        }




        private void PatientCreateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPatient NewP = new NewPatient();
            NewP.sendID = string.Format(string.Format("{0:0000}", Patientid));
            NewP.ShowDialog();
            if (!string.IsNullOrEmpty(NewP.NewPatientName))
            {
                PatientList.Add(new Patient(NewP.sendID, NewP.NewPatientName, Convert.ToInt32(NewP.NewPatientPhone),
                Convert.ToInt32(NewP.NewPatientAge), NewP.NewPatientRoom, NewP.NewPatientAddress, NewP.NewPatientGender));

                string[] column = new string[] {NewP.sendID,NewP.NewPatientName
                    ,NewP.NewPatientRoom,NewP.NewPatientPhone,NewP.NewPatientAddress
                    ,NewP.NewPatientAge,NewP.NewPatientGender };
                ListViewItem row = new ListViewItem(column);
                PatientListView.Items.Add(row);
                PatientInterface.Patientid++;
            }
        }




        public void PatientListView_MouseClick(object sender, MouseEventArgs e)
        {
            clrscreen();
            PatientIDTextbox.Text = PatientListView.SelectedItems[0].SubItems[0].Text;
            PatientNameTextBox.Text = PatientListView.SelectedItems[0].SubItems[1].Text;
            PatientRoomTextBox.Text = PatientListView.SelectedItems[0].SubItems[2].Text;
            PatientPhoneNumberTextBox.Text = PatientListView.SelectedItems[0].SubItems[3].Text;
            PatientAddressTextBox.Text = PatientListView.SelectedItems[0].SubItems[4].Text;
            PatientAgeTextBox.Text = PatientListView.SelectedItems[0].SubItems[5].Text;
            if (PatientListView.SelectedItems[0].SubItems[6].Text == "Male")
            {
                MaleRadioButton.PerformClick();
            }
            else
            {
                FemaleRadioButton.PerformClick();
            }
        }





        private void DeletePatientLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            for(int index = 0;index < PatientList.Count;index++)
            {
                if (PatientList[index].PatientID == PatientListView.SelectedItems[0].SubItems[0].Text)
                {
                    PatientList.RemoveAt(index);
                    PatientListView.SelectedItems[0].Remove();
                    clrscreen();
                }

            }
            
        }





        private void UpdateButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < PatientList.Count; index++)
            {


                if (PatientListView.SelectedItems[0].SubItems[0].Text == PatientList[index].PatientID)
                {
                    string Gender;
                    PatientListView.SelectedItems[0].SubItems[1].Text = PatientNameTextBox.Text;
                    PatientListView.SelectedItems[0].SubItems[2].Text = PatientRoomTextBox.Text;
                    PatientListView.SelectedItems[0].SubItems[3].Text = PatientPhoneNumberTextBox.Text;
                    PatientListView.SelectedItems[0].SubItems[4].Text = PatientAddressTextBox.Text;
                    PatientListView.SelectedItems[0].SubItems[5].Text = PatientAgeTextBox.Text;
                    if (MaleRadioButton.Checked)
                    {
                        Gender = "male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    PatientListView.SelectedItems[0].SubItems[6].Text = Gender;
                    PatientList[index].PatientName = PatientNameTextBox.Text;
                    PatientList[index].PatientRoom = PatientRoomTextBox.Text;
                    PatientList[index].PatientPhone = Convert.ToInt32(PatientPhoneNumberTextBox.Text);
                    PatientList[index].PatientAddress = PatientAddressTextBox.Text;
                    PatientList[index].PatientAge = Convert.ToInt32(PatientAgeTextBox.Text);
                    PatientList[index].PatientGender = Gender;

                    MessageBox.Show("Profile updated");
                }

            }
        }




        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            { 
                for(int index1 = 0; index1 < PatientListView.Items.Count;index1++)
                {
                    for(int index2 = 0; index2 < PatientListView.Items[index1].SubItems.Count;index2++)
                    if(PatientListView.Items[index1].SubItems[index2].Text.ToLower().Contains(SearchBox.Text.ToLower()))
                    {
                        PatientListView.Items[index1].Selected = true;
                        PatientListView.Items[index1].Focused = true;
                    }
                }
            }
        }

        private void PatientInterface_Load(object sender, EventArgs e)
        {

        }

        private void PatientPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input) && input != 8)
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

        private void PatientListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientListLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
