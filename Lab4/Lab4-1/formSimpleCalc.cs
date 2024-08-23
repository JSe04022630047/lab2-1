using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    public partial class formSimpleCalc : Form
    {
        public formSimpleCalc()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Double num1 = 0;
            Double num2 = 0;
            try
            {
                num1 = Double.Parse(textNumber1.Text);
                num2 = Double.Parse(textNumber2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(String.Format("{0}\nYou must enter two integers, please try again.",ex.Message));
                return;
            }
            double result = 0;
            int operation = 0;

            foreach (Control control in this.Controls) 
            {
                if (control is RadioButton && (control as RadioButton).Checked)
                {
                    operation = operationR(control.Name);
                    break;
                }
            }

            switch (operation)
            {
                case 0:
                    MessageBox.Show("No operation");
                    break;
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    try
                    {
                        result = num1 / num2;

                        if (Double.IsInfinity(result))
                        {
                            throw new infinityException("Cannot divide by 0");
                        }
                    }
                    catch (infinityException ex)
                    {
                        MessageBox.Show(String.Format("{0}\nCannot divide by 0",ex.Message));
                        return;
                    }
                    catch (DivideByZeroException divideByZeroException)
                    {
                        MessageBox.Show(String.Format("{0}\nZero is an invalid demoinator. Please try again.",divideByZeroException.Message));
                        return;
                    }
                    break;
            }

            labelResult.Text = result.ToString();
        }

        private int operationR(string name)
        {
            switch (name)
            {
                case "radioAdd":
                    return 1;
                case "radioSubtract":
                    return 2;
                case "radioMultiply":
                    return 3;
                case "radioDivide":
                    return 4;
            }
            return 0;
        }
    }
}
