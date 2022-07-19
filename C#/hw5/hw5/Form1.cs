using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0) 
            {
                listBox1.Items.Add("프로그래밍 도서");
                listBox1.Items.Add("AI 도서");
                listBox1.Items.Add("IoT 도서");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("세계사");
                listBox1.Items.Add("한국사");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("음악");
                listBox1.Items.Add("미술");
                listBox1.Items.Add("체육");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add("C#");
                listBox2.Items.Add("JAVA");
                listBox2.Items.Add("Python");
            }
            else if(comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add("Orange 데이터 마이닝");
                listBox2.Items.Add("OpenCV");
                listBox2.Items.Add("딥러닝");
            }
            else if (comboBox1.SelectedIndex == 0 && listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add("라즈베리파이");
                listBox2.Items.Add("아두이노");
                listBox2.Items.Add("젯슨나노");
            }
            else if (comboBox1.SelectedIndex == 1 && listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add("먼나라 이웃나라-한국편");
                listBox2.Items.Add("근현대사");
            }
            else if (comboBox1.SelectedIndex == 1 && listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add("걸어서 세계속으로");
                listBox2.Items.Add("거꾸로 읽는 세계사");
                listBox2.Items.Add("벌거벗은 세계사");
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add("피아노 완전 정복하기");
                listBox2.Items.Add("나도 바이올린 잘쳐보자 ~");
                listBox2.Items.Add("기타 독학 가능?");
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add("그림을 그려보아요");
                listBox2.Items.Add("나도 할수있다 피카소");
                listBox2.Items.Add("그림그림그림");
            }
            else if (comboBox1.SelectedIndex == 2 && listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add("스포츠 지도사");
                listBox2.Items.Add("체육백서");
                listBox2.Items.Add("기계체조");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "미지정";
            if (radioButton1.Checked == true) { sex = "남성"; }
            else if (radioButton2.Checked == true) { sex = "여성"; }

            string[] contants = {textBox1.Text, textBox2.Text, textBox3.Text, sex, textBox5.Text, textBox6.Text, textBox7.Text , textBox8.Text, listBox2.SelectedItem.ToString()};
            ListViewItem listitem = new ListViewItem(contants);
            
            listView1.Items.Add(listitem);
        }
    }
}
