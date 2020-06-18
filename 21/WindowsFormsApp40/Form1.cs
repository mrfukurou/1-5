using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType("WindowsFormsApp40." + textBox1.Text);
            ISomeInterface w = (ISomeInterface)Activator.CreateInstance(t);
            w.SomeMethod();
        }
    }
        public interface ISomeInterface
        {
            void SomeMethod();
        }
        public class Class1 : ISomeInterface
        {
            public void SomeMethod()
            {
                System.Windows.Forms.MessageBox.Show("Class1");
            }
        }

        public class Class2 : ISomeInterface
        {
            public void SomeMethod()
            {
                System.Windows.Forms.MessageBox.Show("Class2");
            }
        }
    
}
