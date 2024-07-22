namespace Csharp_TinhChuViDienTich_WinForm
{
    partial class HinhChuNhat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dai = new TextBox();
            rong = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            tcv = new Button();
            tdt = new Button();
            button3 = new Button();
            label3 = new Label();
            kqcv = new TextBox();
            kqdt = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // dai
            // 
            dai.Location = new Point(362, 106);
            dai.Name = "dai";
            dai.Size = new Size(192, 38);
            dai.TabIndex = 0;
            // 
            // rong
            // 
            rong.Location = new Point(362, 196);
            rong.Name = "rong";
            rong.Size = new Size(192, 38);
            rong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 106);
            label1.Name = "label1";
            label1.Size = new Size(49, 30);
            label1.TabIndex = 2;
            label1.Text = "Dài";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 199);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 3;
            label2.Text = "Rộng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 192, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(236, 22);
            label5.Name = "label5";
            label5.Size = new Size(434, 30);
            label5.TabIndex = 8;
            label5.Text = "Tính Chu Vi, Diện Tích Hình Chữ Nhật";
            label5.Click += label5_Click;
            // 
            // tcv
            // 
            tcv.Location = new Point(117, 443);
            tcv.Name = "tcv";
            tcv.Size = new Size(200, 38);
            tcv.TabIndex = 9;
            tcv.Text = "Tính Chu Vi";
            tcv.UseVisualStyleBackColor = true;
            tcv.Click += tcv_Click;
            // 
            // tdt
            // 
            tdt.Location = new Point(372, 443);
            tdt.Name = "tdt";
            tdt.Size = new Size(200, 38);
            tdt.TabIndex = 10;
            tdt.Text = "Tính Diện Tích";
            tdt.UseVisualStyleBackColor = true;
            tdt.Click += tdt_Click;
            // 
            // button3
            // 
            button3.Location = new Point(648, 443);
            button3.Name = "button3";
            button3.Size = new Size(200, 38);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 298);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 12;
            label3.Text = "Chu vi là";
            // 
            // kqcv
            // 
            kqcv.Location = new Point(362, 290);
            kqcv.Name = "kqcv";
            kqcv.Size = new Size(192, 38);
            kqcv.TabIndex = 13;
            // 
            // kqdt
            // 
            kqdt.Location = new Point(362, 363);
            kqdt.Name = "kqdt";
            kqdt.Size = new Size(192, 38);
            kqdt.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 371);
            label4.Name = "label4";
            label4.Size = new Size(145, 30);
            label4.TabIndex = 15;
            label4.Text = "Diện Tích là";
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 518);
            Controls.Add(label4);
            Controls.Add(kqdt);
            Controls.Add(kqcv);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(tdt);
            Controls.Add(tcv);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rong);
            Controls.Add(dai);
            Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "HinhChuNhat";
            Text = "Hình Chữ Nhật";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dai;
        private TextBox rong;
        private Label label1;
        private Label label2;
        private Label label5;
        private Button tcv;
        private Button tdt;
        private Button button3;
        private Label label3;
        private TextBox kqcv;
        private TextBox kqdt;
        private Label label4;
    }
}
