using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using staff_ne;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientInterface p1 = new PatientInterface();
            p1.ShowDialog();
        }

        private void Storage_button_Click(object sender, EventArgs e)
        {
            Storage_UI p2 = new Storage_UI();
            p2.ShowDialog();
        }

        private void StaffListButton_Click(object sender, EventArgs e)
        {
            StafttInterface p3 = new StafttInterface();
            p3.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
