using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using WindowsFormsApp1.UI;

namespace staff_ne
{
    public partial class StafttInterface : Form
    {
        public static List<Staff> Stafflist = new List<Staff>();
        public static int giveID = 1;
        public static int SIN; //Selected index of the selected Doctor

        public StafttInterface()
        {
            InitializeComponent();
            int index = 0;
            while (StaffListView.Items.Count != Stafflist.Count)
            {
                string[] column = new string[] { Stafflist[index].StaffID,
                Stafflist[index].StaffName,
               Convert.ToString(Stafflist[index].StaffPhoneNumber),
               Stafflist[index].StaffAddress,
               Convert.ToString(Stafflist[index].StaffAge),
               Stafflist[index].StaffGender };

               ListViewItem row = new ListViewItem(column);
               StaffListView.Items.Add(row);
                index++;
            };

         }
        
    
        private  void clearing()
        {

        }

        private void StaffCreateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNewStaff NewStaff = new CreateNewStaff();
            
            NewStaff.ShowDialog();
            NewStaff.SendID = string.Format(string.Format("{0:0000}", StafttInterface.giveID));
            if (!string.IsNullOrEmpty(NewStaff.StaffName))
            {
                Stafflist.Add(new Staff(NewStaff.SendID, NewStaff.StaffName, NewStaff.PhoneNumber, NewStaff.Address, NewStaff.Age, NewStaff.Gender));

                string[] column = new string[] { NewStaff.SendID, NewStaff.StaffName,
            Convert.ToString(NewStaff.PhoneNumber),NewStaff.Address,Convert.ToString(NewStaff.Age),NewStaff.Gender};
                ListViewItem row = new ListViewItem(column);
                StaffListView.Items.Add(row);
                giveID++;
            }
            
        }        
      
        private void StaffPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if(!char.IsDigit(input)&& input !=8)
            {
                e.Handled = true;
            }
        }


    

        private void StaffNameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StaffAgeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string Gender;
            for (int index = 0;index<Stafflist.Count;index++)
            {              
                if (StaffListView.SelectedItems[0].SubItems[0].Text==Stafflist[index].StaffID)
                {
                    StaffListView.SelectedItems[0].SubItems[1].Text = StaffNameTextBox.Text;
                    StaffListView.SelectedItems[0].SubItems[2].Text = StaffPhoneNumberTextBox.Text;
                    StaffListView.SelectedItems[0].SubItems[3].Text = StaffAddressTextBox.Text;
                    StaffListView.SelectedItems[0].SubItems[4].Text = StaffAgeTextBox.Text;
                    if(MaleRadioButton.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    StaffListView.SelectedItems[0].SubItems[5].Text = Gender;
                    Stafflist[index].StaffPhoneNumber = Convert.ToInt32(StaffPhoneNumberTextBox.Text);
                    Stafflist[index].StaffAddress = StaffAddressTextBox.Text;
                    Stafflist[index].StaffAge = Convert.ToInt32(StaffAgeTextBox.Text);
                    Stafflist[index].StaffGender = Gender;
                    MessageBox.Show("profile updated");                  
                }
            }
        }

        private void DeleteStaffLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int index = 0; index < Stafflist.Count; index++)
            {
                if (StaffListView.SelectedItems[0].SubItems[0].Text == Stafflist[index].StaffID)
                {
                    Stafflist.RemoveAt(index);
                    StaffListView.SelectedItems[0].Remove();

                }
            }
        }

        private void StaffListView_MouseClick(object sender, MouseEventArgs e)
        {
            StaffIDTextbox.Text = StaffListView.SelectedItems[0].SubItems[0].Text;
            StaffNameTextBox.Text = StaffListView.SelectedItems[0].SubItems[1].Text;
            StaffPhoneNumberTextBox.Text = StaffListView.SelectedItems[0].SubItems[2].Text;
            StaffAddressTextBox.Text = StaffListView.SelectedItems[0].SubItems[3].Text;
            StaffAgeTextBox.Text = StaffListView.SelectedItems[0].SubItems[4].Text;
            if (StaffListView.SelectedItems[0].SubItems[5].Text == "Male")
            {
                MaleRadioButton.PerformClick();
            }
            else
            {
                FemaleRadioButton.PerformClick();
            }
            SIN = StaffListView.Items.IndexOf(StaffListView.SelectedItems[0]);
        }

        private void StaffListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if(StaffListView.SelectedItems.Count != 0)
            {
                SelectPatient p1 = new SelectPatient();
                p1.ShowDialog();


                    

            }

        }
    }
}
