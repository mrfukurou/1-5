using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Drawing.Text.InstalledFontCollection fontList =
            new System.Drawing.Text.InstalledFontCollection();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily ff in fontList.Families)
            {
                listBox1.Items.Add(ff.Name);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(listBox1.Text, 20);
        }
    }
}
