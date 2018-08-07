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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        public DisplayForm(string title, string message)
        {

            InitializeComponent();
            Text = title;
            label1.Text = message;

        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
