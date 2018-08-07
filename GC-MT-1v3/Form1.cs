using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GC_MT_1
{
    public partial class Form1 : Form
    {

    public Form1()
        {
            InitializeComponent();
        }

        public void SetMenu(Product[] menu)     //Initializer Sorta Thing
        {
            MenuList = menu;
            Receipt = new int[menu.Length];
            printMenu.View = View.Details;
            printReceipt.View = View.Details;
            printMenu.Columns.Add("Menu Number");
            printMenu.Columns.Add("Category");
            printMenu.Columns.Add("Item Name", 150);
            printMenu.Columns.Add("Price");
            printReceipt.Columns.Add("Quantity");
            printReceipt.Columns.Add("Item", 150);
            printReceipt.Columns.Add("Unit Total");
            displayDesc.Text = "";
            displayName.Text = "";
            cost.Text = "";
            subtotal.Text = "";
            total.Text = "";
            orderQuantity.Minimum = 0;
            orderQuantity.Maximum = 99;
            int counter = 1;
            foreach (Product f in menu)
            {
                ListViewItem temp1 = new ListViewItem (new[] { $"{counter}", f.FoodCategory, f.FoodName, $"{f.FoodPrice:c}" });
                printMenu.Items.Add(temp1);
                menuSelect.Items.Add($"{f.FoodName} {f.FoodPrice:c}");
                counter++;
            }

        }
        
        public int Index { set; get; }
        public int Quantity { set; get; }
        public double Price { set; get; }
        public Product[] MenuList { set; get; }
        public int[] Receipt { set; get; }

        private void menuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = menuSelect.SelectedIndex;
            Price = MenuList[Index].FoodPrice;
            cost.Text = $"{Price * Quantity:c}";
            displayDesc.Text = MenuList[Index].FoodDescription;
            displayName.Text = MenuList[Index].FoodName;
        }

        private void orderQuantity_ValueChanged(object sender, EventArgs e)
        {
            Quantity = Convert.ToInt32(orderQuantity.Value);
            cost.Text = $"{Price * Quantity:c}";
        }

        private void displayName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printReceipt.Items.Clear();
            Receipt[Index] = Quantity;
            for (int i = 0; i < Receipt.Length; i++)
            {
                if (Receipt[i] > 0)
                {
                    ListViewItem temp = new ListViewItem(new[] {$"{Receipt[i]}", MenuList[i].FoodName, $"{Receipt[i] * MenuList[i].FoodPrice:c}"});
                    printReceipt.Items.Add(temp);
                }
            }

            double subTotal = 0;
            for (int i = 0; i < Receipt.Length; i++)
            {

                if (Receipt[i] > 0)
                {

                    Console.WriteLine($"{Receipt[i]} {MenuList[i].FoodName} {Receipt[i] * MenuList[i].FoodPrice:c}");
                    subTotal += Receipt[i] * MenuList[i].FoodPrice;

                }

            }
            subtotal.Text = $"Subtotal: {subTotal:c}";
            total.Text = $"Total: {subTotal * 1.06:c}";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void printReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
