using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_MT_1
{
    public partial class Form1 : Form
    {

    //    Form1 f = new Form1();

    //    f.ShowDialog(); 


    //        StreamReader menu = new StreamReader("../../Menu.txt");
    //    string RESTAURANTNAME = menu.ReadLine();
    //    Product[] MENU = ArrayBuilder2(ArrayBuilder1(menu));

    //    Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Application.Run(new Form1());

    //        double price = 0;
    //    int[] receipt = OrderList(MENU);
    //        for (int i = 0; i<MENU.Length; i++)
    //        {
    //            price += receipt[i] * MENU[i].FoodPrice;
    //        }

    //PrintReceipt(receipt, MENU);
    ////PaymentMethod.Cash(price * 1.06);
    //GetPayment(price* 1.06);

    public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            int r = n1 + n2;

            label1.Text = r.ToString();

            MessageBox.Show(r.ToString(),"Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text; 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Credit Card")
            {
                panel1.Show();
            }
            else
            {
                panel1.Hide();
            }
        }
    }
}
