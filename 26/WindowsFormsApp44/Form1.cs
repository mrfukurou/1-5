using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр класса, соответствующего второй форме
            Form2 f = new Form2();
            // Если нажата кнопка OK
            if (f.ShowDialog() == DialogResult.OK)
            {
                // то передаем данные из текстового поля второй формы в поле на первой форме
                textBox1.Text = f.textBox1.Text;

            }
        }
    }
}
