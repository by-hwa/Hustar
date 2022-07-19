using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day6_1
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
        string path = @"D:\fs.txt";
        private void btncopy_Click(object sender, EventArgs e)
        {
            

            try
            {
                listBox1.Items.Clear();
                if (File.Exists(path)) // Exists 경로가 존재하는지 확인
                {
                    File.Copy(path, @"D:\fs_copy.txt"); // 파일 복사
                    listBox1.Items.Add("복사 끝~");
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("파일이 없어!!!");
                }
            }
            catch(Exception)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("이미 파일이 있어!!!");
            }
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            //Directory
            //Name
            //Extension
            //CreateTime
            //Length
            FileInfo fileinfo = new FileInfo(path);
            listBox1.Items.Clear();
            listBox1.Items.Add("파일경로 : " + fileinfo.Directory);
            listBox1.Items.Add("파일이름 : " + fileinfo.Name);
            listBox1.Items.Add("전체경로 : " + fileinfo.FullName);
            listBox1.Items.Add("확장자명 : " + fileinfo.Extension); // 확장자
            listBox1.Items.Add("생성시간 : " + fileinfo.CreationTime);
            listBox1.Items.Add("파일크기 : " + fileinfo.Length); // 파일크기
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\fs.txt", FileMode.Create, FileAccess.Write); ;
            byte[] data = new byte[26];

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(65+i);
            }
            fs.Write(data, 0, data.Length);
            fs.Close();
            MessageBox.Show("파일 기록");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\fs.txt", FileMode.Open, FileAccess.Read);
                byte[] readData = new byte[26];
                fs.Read(readData, 0, readData.Length);
                fs.Close();

                for (int i = 0; i < readData.Length; i++)
                {
                    textBox1.Text += Convert.ToChar(readData[i]) + ",";
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("파일을 찾을 수 없습니다.");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\sw.txt");
            sw.WriteLine(textBox2.Text);
            sw.Close();
            MessageBox.Show("텍스트 저장");
        }

        private void btnread1_Click(object sender, EventArgs e)
        {
            // clt + k + c clt + k + u

            char[] buffer = new char[10];
            int charCount = 0;
            StreamReader sr = new StreamReader(@"D:\fs.txt");
            textBox2.Text = "";

            //while (!sr.EndOfStream)
            //{
            //    charCount = sr.Read(buffer, 0, 1);

            //    for (int i = 0; i < charCount; i++)
            //    {
            //        textBox2.Text += buffer[i];
            //    }               
            //}
            //sr.Close();

            while (!sr.EndOfStream)
            {
                textBox2.Text = sr.ReadLine();
            }

            textBox2.Text = sr.ReadToEnd();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label4.Text= "새로만들기";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label4.Text = "열기";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label4.Text = "저장";
        }
    }
}
