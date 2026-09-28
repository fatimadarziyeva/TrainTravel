namespace WinFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            maskedTextBox6 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox7 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 76);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 22);
            label1.Name = "label1";
            label1.Size = new Size(207, 35);
            label1.TabIndex = 5;
            label1.Text = "TRAIN TRAVEL";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 357);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(679, 104);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBox6);
            groupBox1.Controls.Add(maskedTextBox5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 259);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel information";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(258, 37);
            button4.Name = "button4";
            button4.Size = new Size(35, 77);
            button4.TabIndex = 8;
            button4.Text = "< >";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 171);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 7;
            label5.Text = "Yer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 129);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 6;
            label4.Text = "Tarix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 84);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 5;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Haradan:";
            label2.Click += label2_Click;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.BackColor = Color.Gray;
            maskedTextBox6.Location = new Point(127, 171);
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(166, 28);
            maskedTextBox6.TabIndex = 3;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BackColor = Color.Gray;
            maskedTextBox5.Location = new Point(127, 125);
            maskedTextBox5.Mask = "00/00/0000 90:00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(166, 28);
            maskedTextBox5.TabIndex = 2;
            maskedTextBox5.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Gray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakı", "Lənkəran", "Gəncə", "Gədəbəy", "Qazax" });
            comboBox2.Location = new Point(127, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(113, 29);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bakı", "Lənkəran", "Gəncə", "Gədəbəy", "Qazax" });
            comboBox1.Location = new Point(127, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 29);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox7);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(365, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 259);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person information";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gray;
            textBox1.Location = new Point(159, 78);
            textBox1.MaxLength = 7;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 28);
            textBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 205);
            button3.Name = "button3";
            button3.Size = new Size(306, 48);
            button3.TabIndex = 7;
            button3.Text = "Bilet al";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 174);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 8;
            label9.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 132);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 7;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 85);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 6;
            label7.Text = "Fin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 36);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 5;
            label6.Text = "Ad, Soyad:";
            // 
            // maskedTextBox7
            // 
            maskedTextBox7.BackColor = Color.Gray;
            maskedTextBox7.Location = new Point(159, 37);
            maskedTextBox7.Name = "maskedTextBox7";
            maskedTextBox7.Size = new Size(161, 28);
            maskedTextBox7.TabIndex = 4;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.Gray;
            maskedTextBox4.Location = new Point(159, 171);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(161, 28);
            maskedTextBox4.TabIndex = 3;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.Gray;
            maskedTextBox3.Location = new Point(159, 129);
            maskedTextBox3.Mask = "(994) 00-000-00-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(161, 28);
            maskedTextBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 467);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 5;
            button1.Text = "Siyahıdan sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(535, 467);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 6;
            button2.Text = "Proqramdan çıxış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(567, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(704, 507);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox7;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
