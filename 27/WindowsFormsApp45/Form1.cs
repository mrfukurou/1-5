using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Переменная для хранения выбранного цвета.
        Color color;
        // Массив для хранения пользовательских цветов.
        int[] customColors = new int[] { 0xFF0000, 0xFFFF00, 0xFF00FF };

        private void button1_Click(object sender, EventArgs e)
        {
            // Восстанавливаем пользовательские цвета в диалоге.
            colorDialog1.CustomColors = customColors;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Записываем выбранные пользователем цвета.
                customColors = colorDialog1.CustomColors;
                // Получаем выбранный пользователем цвет.
                color = colorDialog1.Color;

            }
        }
    }
}
