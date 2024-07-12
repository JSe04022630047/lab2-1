using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string theGender = gender();

            string textDisplay = "";
            textDisplay += String.Format("Your name is {0}.\n", textName.Text);
            textDisplay += String.Format("Your address is {0}, {1}.\n", textAddress.Text, listCity.SelectedItem);
            textDisplay += String.Format("You are {0}.\n", theGender);
            string tutorials = tutorialTextReturn();
            textDisplay += String.Format("Your tutorials are:{0}.",tutorials);
            MessageBox.Show(textDisplay);
        }

        private string tutorialTextReturn()
        {
            string toReturn = ""; 
            foreach(CheckBox box in groupTutorial.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    toReturn += " " + box.Text; 
                }
            }
            return toReturn;
        }

        private string gender()
        {
            if (radioMale.Checked == true)
            {
                return radioMale.Text;
            }
            return radioFemale.Text;
        }
    }
}
