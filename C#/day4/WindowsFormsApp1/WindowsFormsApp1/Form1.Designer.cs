namespace WindowsFormsApp1
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
            this.menu = new System.Windows.Forms.Label();
            this.order_result = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.kimchi = new System.Windows.Forms.CheckBox();
            this.porkcutlet = new System.Windows.Forms.CheckBox();
            this.tang = new System.Windows.Forms.CheckBox();
            this.pasta = new System.Windows.Forms.CheckBox();
            this.label_order = new System.Windows.Forms.Label();
            this.private_info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agree = new System.Windows.Forms.RadioButton();
            this.non_agree = new System.Windows.Forms.RadioButton();
            this.apply = new System.Windows.Forms.Button();
            this.order_need = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.receive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Location = new System.Drawing.Point(12, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(118, 48);
            this.menu.TabIndex = 0;
            this.menu.Text = "메뉴";
            // 
            // order_result
            // 
            this.order_result.AutoSize = true;
            this.order_result.Location = new System.Drawing.Point(529, 9);
            this.order_result.Name = "order_result";
            this.order_result.Size = new System.Drawing.Size(216, 48);
            this.order_result.TabIndex = 0;
            this.order_result.Text = "주문결과";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(20, 223);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(483, 70);
            this.order.TabIndex = 1;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // kimchi
            // 
            this.kimchi.AutoSize = true;
            this.kimchi.Location = new System.Drawing.Point(20, 72);
            this.kimchi.Name = "kimchi";
            this.kimchi.Size = new System.Drawing.Size(235, 52);
            this.kimchi.TabIndex = 2;
            this.kimchi.Text = "김치찌개";
            this.kimchi.UseVisualStyleBackColor = true;
            // 
            // porkcutlet
            // 
            this.porkcutlet.AutoSize = true;
            this.porkcutlet.Location = new System.Drawing.Point(329, 72);
            this.porkcutlet.Name = "porkcutlet";
            this.porkcutlet.Size = new System.Drawing.Size(186, 52);
            this.porkcutlet.TabIndex = 2;
            this.porkcutlet.Text = "돈까스";
            this.porkcutlet.UseVisualStyleBackColor = true;
            // 
            // tang
            // 
            this.tang.AutoSize = true;
            this.tang.Location = new System.Drawing.Point(20, 153);
            this.tang.Name = "tang";
            this.tang.Size = new System.Drawing.Size(186, 52);
            this.tang.TabIndex = 2;
            this.tang.Text = "탕수육";
            this.tang.UseVisualStyleBackColor = true;
            // 
            // pasta
            // 
            this.pasta.AutoSize = true;
            this.pasta.Location = new System.Drawing.Point(329, 153);
            this.pasta.Name = "pasta";
            this.pasta.Size = new System.Drawing.Size(186, 52);
            this.pasta.TabIndex = 2;
            this.pasta.Text = "파스타";
            this.pasta.UseVisualStyleBackColor = true;
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Location = new System.Drawing.Point(539, 72);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(0, 48);
            this.label_order.TabIndex = 0;
            // 
            // private_info
            // 
            this.private_info.AutoSize = true;
            this.private_info.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.private_info.Location = new System.Drawing.Point(16, 312);
            this.private_info.Name = "private_info";
            this.private_info.Size = new System.Drawing.Size(521, 48);
            this.private_info.TabIndex = 0;
            this.private_info.Text = "후기를 남겨주시면 이벤트에 응모합니다.\r\n이벤트에 응모하려면 개인정보 동의해주세요.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.non_agree);
            this.groupBox1.Controls.Add(this.agree);
            this.groupBox1.Controls.Add(this.apply);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(32, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보동의";
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(52, 47);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(78, 28);
            this.agree.TabIndex = 0;
            this.agree.TabStop = true;
            this.agree.Text = "동의";
            this.agree.UseVisualStyleBackColor = true;
            // 
            // non_agree
            // 
            this.non_agree.AutoSize = true;
            this.non_agree.Location = new System.Drawing.Point(244, 47);
            this.non_agree.Name = "non_agree";
            this.non_agree.Size = new System.Drawing.Size(128, 28);
            this.non_agree.TabIndex = 0;
            this.non_agree.TabStop = true;
            this.non_agree.Text = "동의안함";
            this.non_agree.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(469, 31);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(188, 60);
            this.apply.TabIndex = 1;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // order_need
            // 
            this.order_need.AutoSize = true;
            this.order_need.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.order_need.Location = new System.Drawing.Point(12, 485);
            this.order_need.Name = "order_need";
            this.order_need.Size = new System.Drawing.Size(185, 24);
            this.order_need.TabIndex = 0;
            this.order_need.Text = "주문시요구사항";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(20, 545);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 35);
            this.textBox1.TabIndex = 4;
            // 
            // receive
            // 
            this.receive.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.receive.Location = new System.Drawing.Point(547, 530);
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(188, 60);
            this.receive.TabIndex = 1;
            this.receive.Text = "Receive";
            this.receive.UseVisualStyleBackColor = true;
            this.receive.Click += new System.EventHandler(this.receive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "신용카드",
            "무통장 입금",
            "포인트 사용"});
            this.comboBox1.Location = new System.Drawing.Point(28, 711);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "결제 방법";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(214, 678);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "결제 정보";
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.pay.Location = new System.Drawing.Point(547, 716);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(188, 60);
            this.pay.TabIndex = 1;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(218, 711);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 76);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(763, 848);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.receive);
            this.Controls.Add(this.pasta);
            this.Controls.Add(this.tang);
            this.Controls.Add(this.porkcutlet);
            this.Controls.Add(this.kimchi);
            this.Controls.Add(this.order);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.private_info);
            this.Controls.Add(this.order_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.order_need);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label order_result;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.CheckBox kimchi;
        private System.Windows.Forms.CheckBox porkcutlet;
        private System.Windows.Forms.CheckBox tang;
        private System.Windows.Forms.CheckBox pasta;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.Label private_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton non_agree;
        private System.Windows.Forms.RadioButton agree;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label order_need;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button receive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.ListBox listBox1;
    }
}

