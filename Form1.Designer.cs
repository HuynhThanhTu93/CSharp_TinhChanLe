namespace CSharp_TinhChanLe
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            lblTong = new Label();
            lblChan = new Label();
            lblTich = new Label();
            lblLe = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH DÃY SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(264, 33);
            label2.TabIndex = 0;
            label2.Text = "Giới hạn của dãy số :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 61);
            label3.Name = "label3";
            label3.Size = new Size(143, 33);
            label3.TabIndex = 0;
            label3.Text = "Số bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 61);
            label4.Name = "label4";
            label4.Size = new Size(148, 33);
            label4.TabIndex = 0;
            label4.Text = "Số kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 157);
            label5.Name = "label5";
            label5.Size = new Size(228, 33);
            label5.TabIndex = 0;
            label5.Text = "Tính tổng các số :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 201);
            label6.Name = "label6";
            label6.Size = new Size(216, 33);
            label6.TabIndex = 0;
            label6.Text = "Tính tích các số :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(239, 33);
            label7.TabIndex = 0;
            label7.Text = "Tổng các số chẵn :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 291);
            label8.Name = "label8";
            label8.Size = new Size(203, 33);
            label8.TabIndex = 0;
            label8.Text = "Tổng các số lẻ :";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(420, 54);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 40);
            txtMin.TabIndex = 1;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(680, 54);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 40);
            txtMax.TabIndex = 2;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(276, 157);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(85, 33);
            lblTong.TabIndex = 0;
            lblTong.Text = "label1";
            // 
            // lblChan
            // 
            lblChan.AutoSize = true;
            lblChan.Location = new Point(276, 247);
            lblChan.Name = "lblChan";
            lblChan.Size = new Size(85, 33);
            lblChan.TabIndex = 0;
            lblChan.Text = "label1";
            // 
            // lblTich
            // 
            lblTich.AutoSize = true;
            lblTich.Location = new Point(276, 201);
            lblTich.Name = "lblTich";
            lblTich.Size = new Size(85, 33);
            lblTich.TabIndex = 0;
            lblTich.Text = "label1";
            // 
            // lblLe
            // 
            lblLe.AutoSize = true;
            lblLe.Location = new Point(276, 291);
            lblLe.Name = "lblLe";
            lblLe.Size = new Size(85, 33);
            lblLe.TabIndex = 0;
            lblLe.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 2;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(666, 435);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 2;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 487);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblTich);
            Controls.Add(label6);
            Controls.Add(lblLe);
            Controls.Add(lblChan);
            Controls.Add(lblTong);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label lblTong;
        private Label lblChan;
        private Label lblTich;
        private Label lblLe;
        private Button button1;
        private Button button2;
    }
}
