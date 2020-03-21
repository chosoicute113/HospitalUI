using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Class;
using staff_ne;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1.Class
{
    public partial class SelectPatient : Form
    {

        public SelectPatient()
        {
            InitializeComponent();
            LoadSelectedPatient(SPListView);
            Loadpatient(APListView);


        }

        private void APListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if(APListView.SelectedItems.Count != 0)
            {
                int Index = 0;
                foreach(Patient item in PatientInterface.PatientList)
                {
                    
                    if(APListView.SelectedItems[0].SubItems[0].Text == item.PatientID)
                    {
                        break;
                    }
                    Index++;
                }
                StafttInterface.Stafflist[StafttInterface.SIN].AddSP(PatientInterface.PatientList[Index]);
                PatientInterface.PatientList[Index].isBeingTreat = true;
                string[] column = new string[] { APListView.SelectedItems[0].SubItems[0].Text, APListView.SelectedItems[0].SubItems[1].Text,
                APListView.SelectedItems[0].SubItems[2].Text, APListView.SelectedItems[0].SubItems[3].Text,
                APListView.SelectedItems[0].SubItems[4].Text, APListView.SelectedItems[0].SubItems[5].Text,APListView.SelectedItems[0].SubItems[6].Text };
                ListViewItem row = new ListViewItem(column);
                SPListView.Items.Add(row);
                APListView.SelectedItems[0].Remove();
            }
            
            
        }

        private void SelectPatient_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RenoveButton_Click(object sender, EventArgs e)
        {
            for(int index = 0;index < StafttInterface.Stafflist[StafttInterface.SIN].SPlist.Count;index++)
            {
                if(SPListView.SelectedItems[0].SubItems[0].Text == StafttInterface.Stafflist[StafttInterface.SIN].SPlist[index].PatientID)
                {
                    StafttInterface.Stafflist[StafttInterface.SIN].SPlist.RemoveAt(index);
                    SPListView.SelectedItems[0].Remove();


                }
            }
        }
        private void Loadpatient(ListView name)
        {
            foreach(Patient item in PatientInterface.PatientList)
            {
                if(item.isBeingTreat == false)
                {
                    string[] column = new string[] { item.PatientID, item.PatientName, item.PatientPhone.ToString(), item.PatientAge.ToString(), item.PatientRoom, item.PatientAddress, item.PatientGender };
                    ListViewItem row = new ListViewItem(column);
                    name.Items.Add(row);
                }
                
            }
            
        }
        private void LoadSelectedPatient(ListView name)
        {
            foreach (Patient item in StafttInterface.Stafflist[StafttInterface.SIN].SPlist)
            {

                string[] column = new string[] { item.PatientID, item.PatientName, item.PatientPhone.ToString(), item.PatientAge.ToString(), item.PatientRoom, item.PatientAddress, item.PatientGender };
                ListViewItem row = new ListViewItem(column);
                name.Items.Add(row);
            }
        }
    }
}
