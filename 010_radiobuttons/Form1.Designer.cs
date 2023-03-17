namespace _010_radiobuttons
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
            this.rbKorea = new System.Windows.Forms.RadioButton();
            this.rbchina = new System.Windows.Forms.RadioButton();
            this.rbjapan = new System.Windows.Forms.RadioButton();
            this.rbothers = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbKorea
            // 
            this.rbKorea.AutoSize = true;
            this.rbKorea.Location = new System.Drawing.Point(19, 22);
            this.rbKorea.Name = "rbKorea";
            this.rbKorea.Size = new System.Drawing.Size(71, 16);
            this.rbKorea.TabIndex = 0;
            this.rbKorea.TabStop = true;
            this.rbKorea.Text = "대한민국";
            this.rbKorea.UseVisualStyleBackColor = true;
            // 
            // rbchina
            // 
            this.rbchina.AutoSize = true;
            this.rbchina.Location = new System.Drawing.Point(19, 44);
            this.rbchina.Name = "rbchina";
            this.rbchina.Size = new System.Drawing.Size(47, 16);
            this.rbchina.TabIndex = 1;
            this.rbchina.TabStop = true;
            this.rbchina.Text = "중국";
            this.rbchina.UseVisualStyleBackColor = true;
            // 
            // rbjapan
            // 
            this.rbjapan.AutoSize = true;
            this.rbjapan.Location = new System.Drawing.Point(19, 66);
            this.rbjapan.Name = "rbjapan";
            this.rbjapan.Size = new System.Drawing.Size(47, 16);
            this.rbjapan.TabIndex = 2;
            this.rbjapan.TabStop = true;
            this.rbjapan.Text = "일본";
            this.rbjapan.UseVisualStyleBackColor = true;
            // 
            // rbothers
            // 
            this.rbothers.AutoSize = true;
            this.rbothers.Location = new System.Drawing.Point(19, 88);
            this.rbothers.Name = "rbothers";
            this.rbothers.Size = new System.Drawing.Size(91, 16);
            this.rbothers.TabIndex = 3;
            this.rbothers.TabStop = true;
            this.rbothers.Text = "그 외의 국가";
            this.rbothers.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbothers);
            this.groupBox1.Controls.Add(this.rbKorea);
            this.groupBox1.Controls.Add(this.rbjapan);
            this.groupBox1.Controls.Add(this.rbchina);
            this.groupBox1.Location = new System.Drawing.Point(46, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfemale);
            this.groupBox2.Controls.Add(this.rbmale);
            this.groupBox2.Location = new System.Drawing.Point(311, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(48, 33);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(35, 16);
            this.rbmale.TabIndex = 4;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "남";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(120, 33);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(35, 16);
            this.rbfemale.TabIndex = 5;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "여";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(444, 165);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "제출";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 248);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKorea;
        private System.Windows.Forms.RadioButton rbchina;
        private System.Windows.Forms.RadioButton rbjapan;
        private System.Windows.Forms.RadioButton rbothers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Button btnsubmit;
    }
}

