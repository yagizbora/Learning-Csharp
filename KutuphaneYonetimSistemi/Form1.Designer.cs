namespace KutuphaneYonetimSistemi
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
            button1 = new Button();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(204, 210);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(204, 97);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(167, 23);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(204, 161);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(167, 23);
            textBoxSifre.TabIndex = 2;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(60, 93);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(87, 161);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(439, 377);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kütüphane Yönetim Sistemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
    }
}
