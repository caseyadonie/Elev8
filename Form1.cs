using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorElev8
{
    public partial class Form1 : Form
    {
        string operand = null;
        double FPart = 0;
        double SPart = 0;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblDisplay.Text +=btn.Text;
        }

        private void bttnPlus_Click(object sender, EventArgs e)
        {
            FPart =Convert.ToDouble( lblDisplay.Text);
            lblDisplay.Text = "";

        }

        private void bttnEqualTo_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (FPart + Convert.ToDouble(lblDisplay.Text)).ToString();
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = null;
            FPart = 0;
            SPart = 0;
        }
    }
}
