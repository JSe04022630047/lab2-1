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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            ComboDialog comboDialog = new ComboDialog();

            string[] items = { "10", "14", "18", "20" };
            comboDialog.AddItems(items);
            comboDialog.Description = "กรุณาเลือกขนาดของฟอนต์";

            if (comboDialog.ShowDialog() == DialogResult.OK)
            {
                int size = Convert.ToInt16(comboDialog.SelectedItem);
                Font f = new Font(textBox1.Font.FontFamily, size);
                textBox1.Font = f;
            }
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            ComboDialog dialog = new ComboDialog();

            string[] color = { "Red", "Green", "Blue", "Black" };
            dialog.AddItems(color);
            dialog.Description = "กรุณาเลือกสีของฟอนต์";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = Color.FromName(dialog.SelectedItem);
            }
        }
    }
}
