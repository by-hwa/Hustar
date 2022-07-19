using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void order_Click(object sender, EventArgs e)
        {
            string order_tmp = "";
            label_order.Text = "";
            if (kimchi.Checked) { order_tmp = order_tmp + "김치찌개\n"; }
            if (porkcutlet.Checked) { order_tmp = order_tmp + "돈까스\n"; }
            if (tang.Checked) { order_tmp = order_tmp + "탕수육\n"; }
            if (pasta.Checked) { order_tmp = order_tmp + "파스타\n"; }
            label_order.Text = order_tmp;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (agree.Checked) { MessageBox.Show("개인정보 동의 하셨습니다.","확인!"); }
            else { MessageBox.Show("개인정보 동의하지 않으셨습니다.","확인!"); }
        }

        private void receive_Click(object sender, EventArgs e)
        {
            label1.Text = "주문하신 메뉴는 ";
            if (kimchi.Checked) { label1.Text = label1.Text + " 김치찌개 "; }
            if (porkcutlet.Checked) { label1.Text = label1.Text + " 돈까스 "; }
            if (tang.Checked) { label1.Text = label1.Text  + " 탕수육 "; }
            if (pasta.Checked) { label1.Text = label1.Text + " 파스타 "; }
            label1.Text = label1.Text + "입니다.\n주문시 요구사항은\"" + textBox1.Text + "\"입니다.";
        }

        private void pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제방법 : " + comboBox1.SelectedItem.ToString() + "\n" + listBox1.SelectedItem.ToString() + "(으)로 결제 하셨습니다.","통보");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "신용카드") { // comboBox1.SelectedIndex == 0 사용가능
                listBox1.Items.Add("국민카드"); 
                listBox1.Items.Add("삼성카드"); 
                listBox1.Items.Add("신한카드"); }
            else if (comboBox1.SelectedItem.ToString() == "무통장 입금")
            {
                listBox1.Items.Add("국민은행");
                listBox1.Items.Add("삼성은행");
                listBox1.Items.Add("신한은행");
            }
            else if (comboBox1.SelectedItem.ToString() == "포인트 사용")
            {
                listBox1.Items.Add("해피 포인트");
                listBox1.Items.Add("주유 포인트");
            }
        }
    }
}
