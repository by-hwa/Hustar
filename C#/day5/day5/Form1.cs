using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text)){
                MessageBox.Show("데이터를 입력해주세요 !");
            }
            else
            {
                string[] stritem = new string[] {textBox1.Text, textBox2.Text, textBox3.Text };
                ListViewItem listviews = new ListViewItem(stritem);
                listView1.Items.Add(listviews);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.FocusedItem.Index);
        }
    }
}
