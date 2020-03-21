using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UI;
namespace WindowsFormsApp1
{
    public partial class Storage_UI : Form
    {
        public static List<equipment> equipmentlist = new List<equipment>();
        public static List<Food> foodlist = new List<Food>();
        public static List<Water> waterlist = new List<Water>();
        public static List<Medicine> medicinelist = new List<Medicine>();
        public static string itemtype { get; set; }
        public static int itemid = 0;



        public Storage_UI()
        {
            
            InitializeComponent();
            StorageItemComboBox.Items.Add("Food&Water");
            StorageItemComboBox.Items.Add("Equipment");
            StorageItemComboBox.Items.Add("Medicine");
            if(string.IsNullOrEmpty(StorageItemComboBox.Text))
            {
                StorageItemAdd.Enabled = false;
                EditLinkLabel.Enabled = false;
                DeleteLinkLabel.Enabled = false;
                EditGroupbox.Visible = false;
            }




        }

        private void Storage_UI_Load(object sender, EventArgs e)
        {

        }

        private void StorageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void StorageItemAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewItem item = new NewItem();
            item.ShowDialog();
            
            if (item.ItemName != null)//check
            {
                if (itemtype == "Food&Water")
                {
                    item.itemid = string.Format(string.Format("S{0:0000}", itemid));
                    if (item.type == 1) //check if User choose Food or Water from ComboBox
                    {
                        foodlist.Add(new Food(item.itemid, item.ItemName,
                            Convert.ToInt32(item.ItemQuantity), item.ExpireDate,item.type));
                        item.ItemQuantity = item.ItemQuantity + item.unit;//Add Kg to the end of the quantity(e.g. 10 Kg)
                        string[] column = new string[] { item.itemid, item.ItemName, item.ItemQuantity, item.ExpireDate };
                        ListViewItem row = new ListViewItem(column);
                        StorageListView.Items.Add(row);
                    }
                    else
                    {
                        waterlist.Add(new Water(item.itemid, item.ItemName,
                            Convert.ToInt32(item.ItemQuantity), item.ExpireDate,item.type));
                        item.ItemQuantity = item.ItemQuantity + item.unit; //Add Liter to the end of the quantity (e.g. 10 Liter)
                        string[] column = new string[] { item.itemid, item.ItemName, item.ItemQuantity, item.ExpireDate };
                        ListViewItem row = new ListViewItem(column);
                        StorageListView.Items.Add(row);
                    }

                }
                else if (itemtype == "Medicine")
                {
                    item.itemid = string.Format(string.Format("M{0:0000}", itemid));
                    medicinelist.Add(new Medicine(item.itemid, item.ItemName,
                            Convert.ToInt32(item.ItemQuantity), item.ExpireDate));
                    string[] column = new string[] { item.itemid, item.ItemName, item.ItemQuantity, item.ExpireDate };
                    ListViewItem row = new ListViewItem(column);
                    StorageListView.Items.Add(row);
                }
                else
                {
                    item.itemid = string.Format(string.Format("E{0:0000}", itemid));
                    equipmentlist.Add(new equipment(item.itemid, item.ItemName,
                            Convert.ToInt32(item.ItemQuantity), item.ExpireDate));
                    string[] column = new string[] { item.itemid, item.ItemName, item.ItemQuantity, item.ExpireDate };
                    ListViewItem row = new ListViewItem(column);
                    StorageListView.Items.Add(row);
                }

                itemid++;
            }
        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Clearing()
        {
            StorageListView.Items.Clear();
        }

        private void StorageItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clearing();
            if (StorageItemComboBox.Text == "Food&Water")
            {
                foreach (Food currentitem in foodlist)
                {
                    string[] column = new string[] { currentitem.id, currentitem.name,
                        currentitem.quantity.ToString(), currentitem.expire_date };
                    ListViewItem row = new ListViewItem(column);
                    StorageListView.Items.Add(row);
                }
                foreach (Water currentitem in waterlist)
                {
                    string[] column = new string[] { currentitem.id, currentitem.name,
                        currentitem.quantity.ToString(), currentitem.expire_date };
                    ListViewItem row = new ListViewItem(column);
                    StorageListView.Items.Add(row);
                }
                itemtype = "Food&Water";
            }
            else if (StorageItemComboBox.Text == "Equipment")
            {
                foreach (equipment currentitem in equipmentlist)
                {
                    string[] column = new string[] { currentitem.id, currentitem.name,
                        currentitem.quantity.ToString(), currentitem.expire_date };
                    ListViewItem row = new ListViewItem(column);
                    StorageListView.Items.Add(row);
                }
                itemtype = "Equipment";
            }
            else
            {
                foreach (Medicine currentitem in medicinelist)
                {
                    string[] column = new string[] { currentitem.id, currentitem.name,
                        currentitem.quantity.ToString(), currentitem.expire_date };
                    ListViewItem row = new ListViewItem(column);
                    StorageListView.Items.Add(row);
                }
                itemtype = "Medicine";
            }
            StorageListView.Refresh();
            StorageItemAdd.Enabled = true;
            DeleteLinkLabel.Enabled = true;
            EditLinkLabel.Enabled = true;
        }

        private void DeleteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewItem item = new NewItem();
            if (itemtype == "Food&Water")
            {

                    for (int index = 0; index < foodlist.Count; index++)
                    {
                        if (foodlist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                        {
                            foodlist.RemoveAt(index);
                            StorageListView.SelectedItems[0].Remove();
                        }
                    }


                    for (int index = 0; index < waterlist.Count; index++)
                    {
                        if (waterlist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                        {
                            waterlist.RemoveAt(index);
                            StorageListView.SelectedItems[0].Remove();
                        }
                    }
            }
            else if(itemtype == "Medicine")
            {
                int index = 0;
                for (index = 0; index < medicinelist.Count; index++)
                {
                    if (medicinelist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                    {
                        medicinelist.RemoveAt(index);
                        StorageListView.SelectedItems[0].Remove();
                    }
                }
            }
            else
            {
                int index = 0;
                for (index = 0; index < equipmentlist.Count; index++)
                {
                    if (equipmentlist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                    {
                        equipmentlist.RemoveAt(index);
                        StorageListView.SelectedItems[0].Remove();
                    }
                }
            }
        }

        private void EditLinkLabel_MouseClick(object sender, MouseEventArgs e)
        {
            EditGroupbox.Visible = true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            NewItem item = new NewItem();
            if (itemtype == "Food&Water")
            {

                for (int index = 0; index < foodlist.Count; index++)
                {
                    if (foodlist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                    {
                        foodlist[index].quantity =Convert.ToInt32(EditQtyTextBox.Text);
                        StorageListView.SelectedItems[0].SubItems[2].Text = EditQtyTextBox.Text + "Kg";
                    }
                }


                for (int index = 0; index < waterlist.Count; index++)
                {
                    if (waterlist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                    {
                        waterlist[index].quantity = Convert.ToInt32(EditQtyTextBox.Text);
                        StorageListView.SelectedItems[0].SubItems[2].Text = EditQtyTextBox.Text + "Liter";
                    }
                }
            }
            else if (itemtype == "Medicine")
            {
                int index = 0;
                for (index = 0; index < medicinelist.Count; index++)
                {
                    if (medicinelist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                    {
                        medicinelist[index].quantity = Convert.ToInt32(EditQtyTextBox.Text);
                        StorageListView.SelectedItems[0].SubItems[2].Text = EditQtyTextBox.Text;
                    }
                }
            }
            else
            {
                int index = 0;
                for (index = 0; index < equipmentlist.Count; index++)
                {
                    if (equipmentlist[index].id == StorageListView.SelectedItems[0].SubItems[0].Text)
                    {
                        equipmentlist[index].quantity = Convert.ToInt32(EditQtyTextBox.Text);
                        StorageListView.SelectedItems[0].SubItems[2].Text = EditQtyTextBox.Text;
                    }
                }
            }
            EditGroupbox.Visible = false;
        }

        private void EditQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if(!char.IsDigit(input) && input != 8)
            {
                e.Handled = true;
            }
        }
    }
}

