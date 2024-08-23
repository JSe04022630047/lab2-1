using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    struct TextDisplay
    {
        public string Text;
        public KnownColor Color;
        public ContentAlignment Alignment;
    }
    public partial class formMain : Form
    {
        TextDisplay td;
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = td.Text;
            labelDisplay.BackColor = Color.FromKnownColor(td.Color);
            labelDisplay.TextAlign = td.Alignment;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            textContent.Text = "Sample Text";

            Type kcolour = typeof(KnownColor);
            string[] knownColours = Enum.GetNames(kcolour);
            comboBGColour.Items.AddRange(knownColours);
            comboBGColour.SelectedIndex = 0;

            Type ct_align = typeof(ContentAlignment);
            string[] contentAlignments = Enum.GetNames(ct_align);
            comboContentAlignment.Items.AddRange(contentAlignments);
            comboContentAlignment.SelectedIndex = 0;
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            td.Text = textContent.Text;

            string bgc = comboBGColour.SelectedItem.ToString();
            Type kcolour = typeof(KnownColor);
            td.Color = (KnownColor)Enum.Parse(kcolour, bgc);

            string cal = comboContentAlignment.SelectedItem.ToString(); // cal short for Content ALignment
            Type ct_align = typeof(ContentAlignment);
            td.Alignment = (ContentAlignment)Enum.Parse(ct_align, cal);
        }
    }
}
