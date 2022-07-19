using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(textBox1.Text);
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Nodes.Add(node);
            }
            else { treeView1.Nodes.Add(node); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            removeCheckedNodes(treeView1.Nodes);
        }

        List<TreeNode> chkNode = new List<TreeNode> { };
        void removeCheckedNodes(TreeNodeCollection nodes)
        {
            List<TreeNode> chkNode = new List<TreeNode>();
            if (nodes != null)
            {
                foreach(TreeNode node in nodes)
                {
                    if (node.Checked)
                    {
                        chkNode.Add(node);
                    }
                    else
                    {
                        removeCheckedNodes(node.Nodes);
                    }
                }
            }
            foreach(TreeNode chknode in chkNode)
            {
                nodes.Remove(chknode);
            }
        }
    }
}
