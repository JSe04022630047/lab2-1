using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_7
{
    public partial class formRational : Form
    {
        private bool signP = true; // dirty way of checking if it a plus or minus
        public formRational()
        {
            InitializeComponent();
            labelResult.Text = "";
            radioPlus.Checked = true;
        }

        private void radioPlus_CheckedChanged(object sender, EventArgs e)
        {
            labelSign.Text = "+";
            signP = true;
        }

        private void radioMinus_CheckedChanged(object sender, EventArgs e)
        {
            labelSign.Text = "-";
            signP = false;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textA.Text);
            double b = Double.Parse(textB.Text);
            double c = Double.Parse(textC.Text);
            double d = Double.Parse(textD.Text);

            Rational first = new Rational(a,b);
            Rational second = new Rational(c,d);
            Rational final = new Rational();
            if (signP)
            { final = first.Add(second); } 
            else 
            { final = first.Subtract(second); }

            labelResult.Text = final.ToString();

        }
    }
}
