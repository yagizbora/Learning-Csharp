namespace WindowsFormsEntry
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBoxTimer = new TextBox();
            btnComboEkle = new Button();
            label3 = new Label();
            btnShow = new Button();
            monthListBox = new ListBox();
            monthTextBox = new TextBox();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            btnRichText = new Button();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            trackBar1 = new TrackBar();
            button6 = new Button();
            groupBox5 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox6 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(16, 31);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 0;
            button1.Text = "Ad";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(16, 70);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 2;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(16, 112);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 4;
            button3.Text = "Labela yaz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 113);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 Day", "3 Day", "5 Day", "1 Week", "3 Week", "1 Months" });
            comboBox1.Location = new Point(4, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxTimer
            // 
            textBoxTimer.Location = new Point(4, 34);
            textBoxTimer.Name = "textBoxTimer";
            textBoxTimer.Size = new Size(164, 23);
            textBoxTimer.TabIndex = 8;
            // 
            // btnComboEkle
            // 
            btnComboEkle.Location = new Point(238, 35);
            btnComboEkle.Name = "btnComboEkle";
            btnComboEkle.Size = new Size(134, 23);
            btnComboEkle.TabIndex = 9;
            btnComboEkle.Text = "Combo'ya veri bas";
            btnComboEkle.UseVisualStyleBackColor = true;
            btnComboEkle.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 124);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "süre";
            label3.Click += label3_Click;
            // 
            // btnShow
            // 
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Location = new Point(6, 116);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(123, 23);
            btnShow.TabIndex = 11;
            btnShow.Text = "Seçileni Göster";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // monthListBox
            // 
            monthListBox.FormattingEnabled = true;
            monthListBox.Items.AddRange(new object[] { "Temmuz", "Ağustos", "Eylül" });
            monthListBox.Location = new Point(56, 22);
            monthListBox.Name = "monthListBox";
            monthListBox.Size = new Size(202, 109);
            monthListBox.TabIndex = 12;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(56, 137);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(202, 23);
            monthTextBox.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(56, 166);
            button4.Name = "button4";
            button4.Size = new Size(202, 23);
            button4.TabIndex = 14;
            button4.Text = "AddMonth";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AddMonth_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(117, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 200);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buton ve textbox";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnComboEkle);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBoxTimer);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnShow);
            groupBox2.Location = new Point(869, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 200);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "ComboBox";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(monthListBox);
            groupBox3.Controls.Add(monthTextBox);
            groupBox3.Controls.Add(button4);
            groupBox3.Location = new Point(1013, 232);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 206);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listbox";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(195, 108);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "C# programming course \n1.C# install\n2.windows form entry\n.\n.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 19;
            // 
            // btnRichText
            // 
            btnRichText.Location = new Point(183, 162);
            btnRichText.Name = "btnRichText";
            btnRichText.Size = new Size(140, 23);
            btnRichText.TabIndex = 20;
            btnRichText.Text = "Metin Ekle";
            btnRichText.UseVisualStyleBackColor = true;
            btnRichText.Click += btnRichText_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox1);
            groupBox4.Controls.Add(btnRichText);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Location = new Point(117, 232);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(333, 206);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rich Text Box";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.crysis_2;
            pictureBox1.Location = new Point(56, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(522, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(522, 261);
            button5.Name = "button5";
            button5.Size = new Size(235, 23);
            button5.TabIndex = 24;
            button5.Text = "Tarih ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(522, 290);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(235, 45);
            trackBar1.TabIndex = 25;
            // 
            // button6
            // 
            button6.Location = new Point(522, 328);
            button6.Name = "button6";
            button6.Size = new Size(235, 35);
            button6.TabIndex = 26;
            button6.Text = "Volume Ekle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Controls.Add(checkBox3);
            groupBox5.Controls.Add(checkBox1);
            groupBox5.Location = new Point(13, 325);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(212, 137);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "Checkbox";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 72);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Kaşar";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 47);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(52, 19);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "Sosis";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Zeytin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton2);
            groupBox6.Controls.Add(radioButton1);
            groupBox6.Location = new Point(13, 168);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(218, 125);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "Cinsiyet";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(40, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kız";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox6);
            panel1.Location = new Point(1291, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 680);
            panel1.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1539, 690);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(trackBar1);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBoxTimer;
        private Button btnComboEkle;
        private Label label3;
        private Button btnShow;
        private ListBox monthListBox;
        private TextBox monthTextBox;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private Button btnRichText;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private TrackBar trackBar1;
        private Button button6;
        private GroupBox groupBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel1;
    }
}
