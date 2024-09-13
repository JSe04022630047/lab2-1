using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/////////////////////////////////////////////////////////////////////////////////////
// Subject          : Object Oriented Programming
// Academic Year    : 1/2022
// Topic      	    : Lab5-1
// Module           : Main Form - formEmployees
// Instructor       : Assistant Prof. Dr.Dome Lohpetch
// Student ID       :
// Student Name     : 
// Lab Date         : 
/////////////////////////////////////////////////////////////////////////////////////

namespace Lab8_1
{
    /////////////////////////////////////////////////////
    // Lab Detail
    /////////////////////////////////////////////////////
    // 1) Complete the code of Employee class as detail in the lab instruction
    // 2) Complete the code of formEmployee form to make program working completely

    public partial class formEmployee : Form
    {
        private Employee _myEmployee = null;

        private void formEmployees_Load(object sender, EventArgs e)
        {
            _myEmployee = new Employee();
            DisplayCurrentEmployee();
            comboPosition.Items.AddRange( new object[5] { "President", "Manager", "Supervisor", "Officer", "Operator" }) ;
            comboPosition.SelectedIndex = 0;
        }

        public formEmployee()
        {
            InitializeComponent();
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            try {
                _myEmployee.ID = textID.Text;
                _myEmployee.Name = textName.Text;
                _myEmployee.Position = comboPosition.SelectedIndex;
                _myEmployee.Salary = double.Parse(textSalary.Text);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayCurrentEmployee()
        {
            labelEmployee.Text = _myEmployee.ToString();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayCurrentEmployee();
        }
    }
}
