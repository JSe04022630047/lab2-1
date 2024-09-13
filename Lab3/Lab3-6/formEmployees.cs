using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_6
{
    public partial class formEmployees : Form
    {
        private Employee theEmployee = new Employee();
        public formEmployees()
        {
            InitializeComponent();
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            string sID = textID.Text;
            string sName = textName.Text;
            double dSalary = 0;
            double.TryParse(textSalary.Text, out double result);
            if (result>0) { dSalary = result; } else { dSalary = 5000; }
            theEmployee = new Employee(sID, sName, dSalary);
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string theText = String.Format("ID: {0}, Name: {1}, Salary: {2:F}",theEmployee.ID, theEmployee.Name, theEmployee.Salary);
            labelInformation.Text = theText;
        }
    }
}
