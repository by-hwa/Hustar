using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Directory 사용을 위해 선언.

namespace day6
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

        private void btndirlist_Click(object sender, EventArgs e)
        {
            lbdir.Items.Clear();
            string[] apaths = Directory.GetDirectories(Environment.SystemDirectory);
            // 윈도우 상위의 정보를 가지고 있는 디렉토리 Environment.SystemDirectory = @"C:\Windows\System32"
            
            foreach(string apath in apaths)
            {
                lbdir.Items.Add(apath);
            }
        }

        private void btnfillist_Click(object sender, EventArgs e)
        {
            lbfiles.Items.Clear();
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory,"*.*"); 
            // "*.exe" 확장자를 지정해주면 지정된 확장자를 가진 파일을 가져옴

            foreach(String afile in afiles)
            {
                lbfiles.Items.Add(afile);
            }
        }

        private void btndirlnfo_Click(object sender, EventArgs e)
        {
            lbdirinfo.Items.Clear();
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Windows");
            if (dirinfo.Exists)
            {
                lbdirinfo.Items.Add("전체경로 : " + dirinfo.FullName); 
                lbdirinfo.Items.Add("디렉토리 이름 : " + dirinfo.Name);
                lbdirinfo.Items.Add("생성일 : " + dirinfo.CreationTime);
                lbdirinfo.Items.Add("속성 : " + dirinfo.Attributes);
                lbdirinfo.Items.Add("루트 : " + dirinfo.Root);
            }
        }
    }
}
