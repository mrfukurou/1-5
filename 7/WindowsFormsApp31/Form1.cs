using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            // Загружаем в xml-документ xml-файл.
            xml.Load("1.xml");
            // Берем корневой узел (тег) xml-документа.
            XmlNode d = xml.DocumentElement;
            // Берем все дочерние теги.
            XmlNodeList xnl = d.ChildNodes;
            // Перебираем все дочерние теги.
            for (int i = 0; i < d.ChildNodes.Count; i++)
            {
                // Выводим атрибуты тегов.
                MessageBox.Show(xnl[i].Attributes["text"].Value + " " +
                    xnl[i].Attributes["rustext"].Value);
            }

        }
    }
}
