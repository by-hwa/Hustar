using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4
{
    public partial class HW4 : Form
    {
        public HW4()
        {
            InitializeComponent();
        }
        private void HW4_Load(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right; // 텍스트 오른쪽 정렬
            textBox1.ReadOnly = true; // 입력 제한 하기
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.ReadOnly = true;
        }

        double num1, num2, result;
        string operater;


        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "10";
        }

        private void f_mul_Click(object sender, EventArgs e)
        {
            operater = "*";
            if (String.IsNullOrEmpty(textBox1.Text)) { num1 = result; }
            else { num1 = Convert.ToDouble(textBox1.Text.ToString()); }
            textBox2.Text = textBox1.Text + operater;
            textBox1.Clear();
        }

        private void f_div_Click(object sender, EventArgs e)
        {
            operater = "/";
            if (String.IsNullOrEmpty(textBox1.Text)) { num1 = result; }
            else { num1 = Convert.ToDouble(textBox1.Text.ToString()); }
            textBox2.Text = textBox1.Text + operater;
            textBox1.Clear();
        }


        public void Equal()
        {
            num2 = Convert.ToDouble(textBox1.Text.ToString());
            if (operater == "*") { result = num1 * num2; }
            else if (operater == "/") { result = num1 / num2; }
            else if (operater == "+") { result = num1 + num2; }
            else if (operater == "-") { result = num1 - num2; }
            else if (operater == "%") { result = num1 % num2; }
            else if (operater == "^") { result = Math.Pow(num1, num2); }

            textBox2.Text = Convert.ToString(result);
            textBox1.Clear();
        }


        private void f_equal_Click(object sender, EventArgs e)
        {
            Equal();
        }

        private void f_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void f_squar_Click(object sender, EventArgs e)
        {
            operater = "^";
            if (String.IsNullOrEmpty(textBox1.Text)) { num1 = result; }
            else { num1 = Convert.ToDouble(textBox1.Text.ToString()); }
            textBox2.Text = textBox1.Text + operater;
            textBox1.Clear();
        }

        private void f_remain_Click(object sender, EventArgs e)
        {
            operater = "%";
            if (String.IsNullOrEmpty(textBox1.Text)) { num1 = result; }
            else { num1 = Convert.ToDouble(textBox1.Text.ToString()); }
            textBox2.Text = textBox1.Text + operater;
            textBox1.Clear();
        }

        private void f_backspace_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text)) { textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); }
        }

        private void f_c_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            operater = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void f_abs_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            result = Math.Abs(Convert.ToDouble(textBox1.Text.ToString()));
            textBox1.Text = Convert.ToString(result);
        }

        private void f_subs_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-")){ textBox1.Text.Replace("-", ""); }
            else { textBox1.Text = "-" + textBox1.Text; }
        }

        private void f_sub_Click(object sender, EventArgs e)
        {
            operater = "-";
            if (String.IsNullOrEmpty(textBox1.Text)) { num1 = result;  }
            else { num1 = Convert.ToDouble(textBox1.Text.ToString()); }
            textBox2.Text = textBox1.Text + operater;
            textBox1.Clear();
        }

        private void f_add_Click(object sender, EventArgs e)
        {   //null or empty 비어있으면 True 반환
            operater = "+";
            if (String.IsNullOrEmpty(textBox1.Text)){ num1 = result;  }
            else { num1 = Convert.ToDouble(textBox1.Text.ToString());}
            textBox2.Text = textBox1.Text + operater;
            textBox1.Clear();
        }
    }
}
