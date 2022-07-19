namespace day6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdir = new System.Windows.Forms.ListBox();
            this.lbfiles = new System.Windows.Forms.ListBox();
            this.lbdirinfo = new System.Windows.Forms.ListBox();
            this.btndirlist = new System.Windows.Forms.Button();
            this.btnfillist = new System.Windows.Forms.Button();
            this.btndirlnfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdir
            // 
            this.lbdir.FormattingEnabled = true;
            this.lbdir.ItemHeight = 12;
            this.lbdir.Location = new System.Drawing.Point(15, 14);
            this.lbdir.Name = "lbdir";
            this.lbdir.Size = new System.Drawing.Size(212, 64);
            this.lbdir.TabIndex = 0;
            // 
            // lbfiles
            // 
            this.lbfiles.FormattingEnabled = true;
            this.lbfiles.ItemHeight = 12;
            this.lbfiles.Location = new System.Drawing.Point(15, 84);
            this.lbfiles.Name = "lbfiles";
            this.lbfiles.Size = new System.Drawing.Size(212, 64);
            this.lbfiles.TabIndex = 0;
            // 
            // lbdirinfo
            // 
            this.lbdirinfo.FormattingEnabled = true;
            this.lbdirinfo.ItemHeight = 12;
            this.lbdirinfo.Location = new System.Drawing.Point(15, 154);
            this.lbdirinfo.Name = "lbdirinfo";
            this.lbdirinfo.Size = new System.Drawing.Size(212, 64);
            this.lbdirinfo.TabIndex = 0;
            // 
            // btndirlist
            // 
            this.btndirlist.Location = new System.Drawing.Point(233, 14);
            this.btndirlist.Name = "btndirlist";
            this.btndirlist.Size = new System.Drawing.Size(125, 64);
            this.btndirlist.TabIndex = 1;
            this.btndirlist.Text = "디렉토리 목록";
            this.btndirlist.UseVisualStyleBackColor = true;
            this.btndirlist.Click += new System.EventHandler(this.btndirlist_Click);
            // 
            // btnfillist
            // 
            this.btnfillist.Location = new System.Drawing.Point(233, 84);
            this.btnfillist.Name = "btnfillist";
            this.btnfillist.Size = new System.Drawing.Size(125, 64);
            this.btnfillist.TabIndex = 1;
            this.btnfillist.Text = "파일 목록";
            this.btnfillist.UseVisualStyleBackColor = true;
            this.btnfillist.Click += new System.EventHandler(this.btnfillist_Click);
            // 
            // btndirlnfo
            // 
            this.btndirlnfo.Location = new System.Drawing.Point(233, 154);
            this.btndirlnfo.Name = "btndirlnfo";
            this.btndirlnfo.Size = new System.Drawing.Size(125, 64);
            this.btndirlnfo.TabIndex = 1;
            this.btndirlnfo.Text = "디렉토리 정보";
            this.btndirlnfo.UseVisualStyleBackColor = true;
            this.btndirlnfo.Click += new System.EventHandler(this.btndirlnfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 235);
            this.Controls.Add(this.btndirlnfo);
            this.Controls.Add(this.btnfillist);
            this.Controls.Add(this.btndirlist);
            this.Controls.Add(this.lbdirinfo);
            this.Controls.Add(this.lbfiles);
            this.Controls.Add(this.lbdir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbdir;
        private System.Windows.Forms.ListBox lbfiles;
        private System.Windows.Forms.ListBox lbdirinfo;
        private System.Windows.Forms.Button btndirlist;
        private System.Windows.Forms.Button btnfillist;
        private System.Windows.Forms.Button btndirlnfo;
    }
}

