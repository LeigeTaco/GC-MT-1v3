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
    public partial class Payment : Form
    {
        public double Price { set; get; }

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(double price)
        {
            InitializeComponent();
            pay.Hide();
            cashAmount.Hide();
            Price = price;
            label2.Text = $"Amount Due: {Price:c}";

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void cash_Click(object sender, EventArgs e)
        {
            label1.Text = "Please enter your payment amount:";
            pay.Show();
            cashAmount.Show();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (cashAmount.Value == 0)
            {
                DisplayForm yikes = new DisplayForm("YIKES!", "Someone call the cops on this shoplifter!");
                yikes.ShowDialog();
            }
            else if (Convert.ToDouble(cashAmount.Value) < Price)
            {
                DisplayForm whoops = new DisplayForm("Close, but no Cigar", $"Your payment was short {Price - Convert.ToDouble(cashAmount.Value):c}");
                whoops.ShowDialog();
            }
            else
            {
                DisplayForm yay = new DisplayForm("Change Due", $"Here is your change of {Convert.ToDouble(cashAmount.Value) - Price:c}");
                yay.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
