using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Установка начальной папки.
            saveFileDialog1.InitialDirectory = "C:\tmp";
            // Задание возможных расширений для файла.
            saveFileDialog1.Filter = "abc files (*.abs)|*.abs|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Код по сохранению...
                string fileName = saveFileDialog1.FileName;
                // ...
            }
        }
    }
}
