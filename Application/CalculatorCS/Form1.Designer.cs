namespace CalculatorCS
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSub = new System.Windows.Forms.Button();
            this.ButtonMul = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(28, 43);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(168, 25);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(28, 117);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(168, 25);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(28, 189);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(168, 25);
            this.TextBox3.TabIndex = 2;
            this.TextBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(103, 83);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(15, 15);
            this.labelOperation.TabIndex = 3;
            this.labelOperation.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(216, 169);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(33, 30);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSub
            // 
            this.ButtonSub.Location = new System.Drawing.Point(255, 169);
            this.ButtonSub.Name = "ButtonSub";
            this.ButtonSub.Size = new System.Drawing.Size(33, 30);
            this.ButtonSub.TabIndex = 6;
            this.ButtonSub.Text = "-";
            this.ButtonSub.UseVisualStyleBackColor = true;
            this.ButtonSub.Click += new System.EventHandler(this.ButtonSub_Click);
            // 
            // ButtonMul
            // 
            this.ButtonMul.Location = new System.Drawing.Point(294, 169);
            this.ButtonMul.Name = "ButtonMul";
            this.ButtonMul.Size = new System.Drawing.Size(33, 30);
            this.ButtonMul.TabIndex = 7;
            this.ButtonMul.Text = "x";
            this.ButtonMul.UseVisualStyleBackColor = true;
            this.ButtonMul.Click += new System.EventHandler(this.ButtonMul_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(333, 169);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(34, 30);
            this.ButtonDiv.TabIndex = 8;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 244);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonMul);
            this.Controls.Add(this.ButtonSub);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSub;
        private System.Windows.Forms.Button ButtonMul;
        private System.Windows.Forms.Button ButtonDiv;
    }
}

