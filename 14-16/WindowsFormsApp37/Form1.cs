using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Получаем выделенный узел.
            TreeNode node = treeView1.SelectedNode;
            // Если ничего не выделено,
            if (node == null)
            {
                // то добавляем в корень.
                treeView1.Nodes.Add(addNodeTextBox.Text);
            }
            else
            {
                // Если выделенный узел существует,
                // то добавляем к нему.
                node.Nodes.Add(addNodeTextBox.Text);
            }
            // Очищаем текстовое поле и переводим на него фокус. 
            addNodeTextBox.Text = "";
            addNodeTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Получаем выделенный узел.
            TreeNode node = treeView1.SelectedNode;
            // Если узел выделен,
            if (node != null)
            {
                // то его и удаляем.
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Снимаем выделение с дерева.
            treeView1.SelectedNode = null;
            // Ищем узел с определенным текстом.
            TreeNode tn = FindNode(treeView1.Nodes, findNodeTextBox.Text);
            // Если нашли,
            if (tn != null)
            {
                // то выделяем узел.
                treeView1.SelectedNode = tn;
                treeView1.Focus();
            }
        }
        private TreeNode FindNode(TreeNodeCollection tnc, string name)
        {
            // Ищем в узлах первого уровня.
            foreach (TreeNode tn in tnc)
            {
                // Если нашли,
                if (tn.Text == name)
                {
                    // то возвращаем.
                    return tn;
                }
            }

            // Ищем в подузлах.
            TreeNode node;
            foreach (TreeNode tn in tnc)
            {
                // Делаем поиск в узлах.
                node = FindNode(tn.Nodes, name);
                // Если нашли,
                if (node != null)
                {
                    // то возвращаем.
                    return node;
                }
            }

            // Ничего не нашли.
            return null;
        }
    }
}
