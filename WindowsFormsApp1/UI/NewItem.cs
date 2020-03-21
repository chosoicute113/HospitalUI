using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UI
{
    public partial class NewItem : Form
    {
        public string itemid;
        public string ItemName { get; set; }
        public string ItemQuantity { get; set; }
        public string ExpireDate { get; set; }
        public int type { get; set; }
        public string unit { get; set; }
        public NewItem()
        {
            
            InitializeComponent();
            FandWComboBox.Items.Add("Food(Kg)");
            FandWComboBox.Items.Add("Drink(Liter)");
            if (Storage_UI.itemtype == "Equipment")
            {
                ItemDateTimePicker.Hide();
                ExpirationDateLabel.Hide();
                TypeLabel.Hide();
                FandWComboBox.Hide();


            }
            else if(Storage_UI.itemtype == "Medicine")
            {
                TypeLabel.Hide();
                FandWComboBox.Hide();
            }
        }

        private void AddItemToStorage_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(Storage_UI.itemtype == "Food&Water"||Storage_UI.itemtype=="Medicine")
            {
                
                if (Storage_UI.itemtype == "Food&Water")
                {
                    if (Checkinfo())
                    {
                        ItemName = ItemNameTextBox.Text;
                        ItemQuantity = ItemQuantityTextBox.Text;
                        ExpireDate = ItemDateTimePicker.Value.ToShortDateString();
                        this.Close();
                    }
                    
                }
                else
                {
                    if (Checkinfo())
                    {
                        ItemName = ItemNameTextBox.Text;
                        ItemQuantity = ItemQuantityTextBox.Text;
                        ExpireDate = ItemDateTimePicker.Value.ToShortDateString();
                        this.Close();
                    }
                }
                
                
            }
            else
            {
                if (Checkinfo())
                {
                    ItemName = ItemNameTextBox.Text;
                    ItemQuantity = ItemQuantityTextBox.Text;
                    ExpireDate = "N/A";
                    
                    Close();
                }
                    
            }


        }
        public bool Checkinfo()
        {
            if(Storage_UI.itemtype == "Food&Water")
            {
                if (string.IsNullOrEmpty(ItemNameTextBox.Text) || string.IsNullOrEmpty(FandWComboBox.Text) ||
                       string.IsNullOrEmpty(ItemQuantityTextBox.Text))
                {
                    MessageBox.Show("Missing information");
                    return false;
                }
                
            }
            else
            {
                if (string.IsNullOrEmpty(ItemNameTextBox.Text) ||
                       string.IsNullOrEmpty(ItemQuantityTextBox.Text))
                {
                    MessageBox.Show("Missing information");
                    return false;
                }
            }
            return true;
        }

        private void FandWComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (FandWComboBox.Text == "Food(Kg)") 
            {
                type = 1;
                unit = "Kg";
            }
            else
            {
                type = 2;
                unit = "Liter";
            }
        }

        private void ItemQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }
    }
}
