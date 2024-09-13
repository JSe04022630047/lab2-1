using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class ComboDialog : Form
    {
        public ComboDialog()
        {
            InitializeComponent();
        }
        public void AddItems(params string[] itms)
        {
            comboBox1.Items.AddRange(itms);
        }
        public string SelectedItem
        {
            get { return comboBox1.SelectedItem.ToString(); }
        }
        public string Description
        {
            set
            {
                label1.Text = value;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
