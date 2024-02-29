namespace ImageColor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Count_Data = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_HSI3 = new System.Windows.Forms.TextBox();
            this.cb_HSI1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_HSI1 = new System.Windows.Forms.TextBox();
            this.cb_HSI0 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_HSI0 = new System.Windows.Forms.TextBox();
            this.comboBox_DeputyName = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Gamma1 = new System.Windows.Forms.CheckBox();
            this.textBox_Gamma1 = new System.Windows.Forms.TextBox();
            this.cb_Gamma0 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Gamma0 = new System.Windows.Forms.TextBox();
            this.RotatingImg = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Images";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 18);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save path";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 18);
            this.button3.TabIndex = 3;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Count_Data
            // 
            this.Count_Data.Location = new System.Drawing.Point(12, 376);
            this.Count_Data.Name = "Count_Data";
            this.Count_Data.Size = new System.Drawing.Size(314, 23);
            this.Count_Data.Step = 1;
            this.Count_Data.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(332, 376);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_HSI3);
            this.groupBox3.Controls.Add(this.cb_HSI1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_HSI1);
            this.groupBox3.Controls.Add(this.cb_HSI0);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_HSI0);
            this.groupBox3.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 82);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "色調";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(303, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "~";
            // 
            // textBox_HSI3
            // 
            this.textBox_HSI3.Location = new System.Drawing.Point(57, 48);
            this.textBox_HSI3.Name = "textBox_HSI3";
            this.textBox_HSI3.Size = new System.Drawing.Size(100, 22);
            this.textBox_HSI3.TabIndex = 17;
            this.textBox_HSI3.Text = "0.8";
            this.textBox_HSI3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_HSI1
            // 
            this.cb_HSI1.AutoSize = true;
            this.cb_HSI1.Location = new System.Drawing.Point(8, 23);
            this.cb_HSI1.Name = "cb_HSI1";
            this.cb_HSI1.Size = new System.Drawing.Size(15, 14);
            this.cb_HSI1.TabIndex = 14;
            this.cb_HSI1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(320, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "1.0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(303, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "~";
            // 
            // textBox_HSI1
            // 
            this.textBox_HSI1.Location = new System.Drawing.Point(57, 20);
            this.textBox_HSI1.Name = "textBox_HSI1";
            this.textBox_HSI1.Size = new System.Drawing.Size(100, 22);
            this.textBox_HSI1.TabIndex = 10;
            this.textBox_HSI1.Text = "1.2";
            this.textBox_HSI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_HSI0
            // 
            this.cb_HSI0.AutoSize = true;
            this.cb_HSI0.Location = new System.Drawing.Point(8, 49);
            this.cb_HSI0.Name = "cb_HSI0";
            this.cb_HSI0.Size = new System.Drawing.Size(15, 14);
            this.cb_HSI0.TabIndex = 7;
            this.cb_HSI0.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // textBox_HSI0
            // 
            this.textBox_HSI0.Location = new System.Drawing.Point(320, 20);
            this.textBox_HSI0.Name = "textBox_HSI0";
            this.textBox_HSI0.Size = new System.Drawing.Size(100, 22);
            this.textBox_HSI0.TabIndex = 7;
            this.textBox_HSI0.Text = "1.1";
            this.textBox_HSI0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_DeputyName
            // 
            this.comboBox_DeputyName.FormattingEnabled = true;
            this.comboBox_DeputyName.Items.AddRange(new object[] {
            "jpg",
            "bmp",
            "png",
            "gif"});
            this.comboBox_DeputyName.Location = new System.Drawing.Point(8, 14);
            this.comboBox_DeputyName.Name = "comboBox_DeputyName";
            this.comboBox_DeputyName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_DeputyName.TabIndex = 7;
            this.comboBox_DeputyName.Text = "Select";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelQuantity);
            this.groupBox5.Controls.Add(this.comboBox_DeputyName);
            this.groupBox5.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(12, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(476, 40);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Deputy Name";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQuantity.Location = new System.Drawing.Point(144, 17);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(54, 12);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cb_Gamma1);
            this.groupBox4.Controls.Add(this.textBox_Gamma1);
            this.groupBox4.Controls.Add(this.cb_Gamma0);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_Gamma0);
            this.groupBox4.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(12, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 82);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gamma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(209, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "ex.  x < 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(209, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "ex.  x > 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(33, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // cb_Gamma1
            // 
            this.cb_Gamma1.AutoSize = true;
            this.cb_Gamma1.Location = new System.Drawing.Point(8, 51);
            this.cb_Gamma1.Name = "cb_Gamma1";
            this.cb_Gamma1.Size = new System.Drawing.Size(15, 14);
            this.cb_Gamma1.TabIndex = 17;
            this.cb_Gamma1.UseVisualStyleBackColor = true;
            // 
            // textBox_Gamma1
            // 
            this.textBox_Gamma1.Location = new System.Drawing.Point(103, 48);
            this.textBox_Gamma1.Name = "textBox_Gamma1";
            this.textBox_Gamma1.Size = new System.Drawing.Size(100, 22);
            this.textBox_Gamma1.TabIndex = 18;
            this.textBox_Gamma1.Text = "0.9";
            this.textBox_Gamma1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_Gamma0
            // 
            this.cb_Gamma0.AutoSize = true;
            this.cb_Gamma0.Location = new System.Drawing.Point(8, 21);
            this.cb_Gamma0.Name = "cb_Gamma0";
            this.cb_Gamma0.Size = new System.Drawing.Size(15, 14);
            this.cb_Gamma0.TabIndex = 14;
            this.cb_Gamma0.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(33, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "*";
            // 
            // textBox_Gamma0
            // 
            this.textBox_Gamma0.Location = new System.Drawing.Point(103, 18);
            this.textBox_Gamma0.Name = "textBox_Gamma0";
            this.textBox_Gamma0.Size = new System.Drawing.Size(100, 22);
            this.textBox_Gamma0.TabIndex = 15;
            this.textBox_Gamma0.Text = "1.1";
            this.textBox_Gamma0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotatingImg
            // 
            this.RotatingImg.AutoSize = true;
            this.RotatingImg.Font = new System.Drawing.Font("DFKai-SB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RotatingImg.Location = new System.Drawing.Point(20, 326);
            this.RotatingImg.Margin = new System.Windows.Forms.Padding(2);
            this.RotatingImg.Name = "RotatingImg";
            this.RotatingImg.Size = new System.Drawing.Size(80, 16);
            this.RotatingImg.TabIndex = 14;
            this.RotatingImg.Text = "Rotating";
            this.RotatingImg.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "倍";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "倍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 418);
            this.Controls.Add(this.RotatingImg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Count_Data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar Count_Data;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_HSI0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_HSI0;
        private System.Windows.Forms.ComboBox comboBox_DeputyName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_HSI1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_Gamma1;
        private System.Windows.Forms.TextBox textBox_Gamma1;
        private System.Windows.Forms.CheckBox cb_Gamma0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Gamma0;
        private System.Windows.Forms.CheckBox RotatingImg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_HSI3;
        private System.Windows.Forms.CheckBox cb_HSI1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

