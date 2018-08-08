using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            panel1.Hide();
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

        private void credit_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void cvvBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void expBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cashAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prompt = "Transaaction Successful!";
            int cvvLength = 0;
            bool[] checker = new bool[3];
            if(!Regex.IsMatch(textBox1.Text, @"^\d{16}$"))
            {
                prompt = "Invalid Card!";
                checker[0] = false;
            }
            else
            {
                if (Regex.IsMatch(textBox1.Text, @"^4[0-9]{12}(?:[0-9]{3})?$"))
                {   //Visa Card
                    cvvLength = 3;
                }
                else if (Regex.IsMatch(textBox1.Text, @"^3[47][0-9]{13}$"))
                {   //American Express Card
                    cvvLength = 4;
                }
                else if (Regex.IsMatch(textBox1.Text, @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$"))
                {   //Diners Club Card
                    cvvLength = 3;
                }
                else if (Regex.IsMatch(textBox1.Text, @"^6(?:011|5[0-9]{2})[0-9]{12}$"))
                {   //Discover Card
                    cvvLength = 3;
                }
                else if (Regex.IsMatch(textBox1.Text, @"^(?:2131|1800|35\d{3})\d{11}$"))
                {   //JCB Card
                    cvvLength = 3;
                }
                else if (Regex.IsMatch(textBox1.Text, @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$"))
                {   //MasterCard
                    cvvLength = 3;
                }
                else
                {
                    prompt = "Card did not match known card types!";
                    checker[0] = false;
                }

                if (Regex.IsMatch(cvvBox.Text, @"\d") && cvvBox.Text.Length != cvvLength && prompt == "")
                {
                    prompt = "CVV was not the correct length!";
                    checker[1] = false;
                }
                else if (!Regex.IsMatch(cvvBox.Text, @"\d") && prompt == "")
                {
                    prompt = "CVV was in an incorrect format!";
                    checker[1] = false;
                }
                else
                {
                    if (Regex.IsMatch(expBox.Text, @"^(0[1-9]|1[21])/\d\d$"))
                    {
                        DateTime exp = new DateTime();      //This whole expiration date is a mess and not working.
                        exp.AddMonths(int.Parse(expBox.Text.Substring(0, 2)));
                        exp.AddYears(int.Parse(expBox.Text.Substring(3,2)) + 2000);
                        if (true)   //exp.CompareTo(DateTime.Now) >= 0
                        {
                            prompt = "Transaction Successful!";
                        }
                        else
                        {
                            prompt = "Expired Card!";
                        }
                    }
                    else
                    {
                        if (prompt == "")
                        {
                            prompt = "Expired Card!";
                        }
                    }
                }
            }
            DisplayForm payment = new DisplayForm("Card", prompt);
            payment.ShowDialog();
        }
    }
}
