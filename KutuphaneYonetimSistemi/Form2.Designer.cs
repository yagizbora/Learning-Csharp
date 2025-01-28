namespace KutuphaneYonetimSistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            buttonara = new Button();
            kitapid = new Label();
            buttonKitapBilgiGuncelle = new Button();
            buttonKitapEkle = new Button();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyadi = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonKitabiOduncVer = new Button();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            textBoxOduncAlan = new TextBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label12 = new Label();
            labelgecikmebedeli = new Label();
            label10 = new Label();
            dataGridViewKitaplar = new DataGridView();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonara);
            groupBox1.Controls.Add(kitapid);
            groupBox1.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyadi);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 279);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve güncelleme";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonara
            // 
            buttonara.Location = new Point(218, 234);
            buttonara.Name = "buttonara";
            buttonara.Size = new Size(100, 39);
            buttonara.TabIndex = 14;
            buttonara.Text = "Ara";
            buttonara.UseVisualStyleBackColor = true;
            buttonara.Click += buttonara_Click;
            // 
            // kitapid
            // 
            kitapid.AutoSize = true;
            kitapid.Location = new Point(98, 28);
            kitapid.Name = "kitapid";
            kitapid.Size = new Size(0, 15);
            kitapid.TabIndex = 13;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(6, 234);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(100, 39);
            buttonKitapBilgiGuncelle.TabIndex = 12;
            buttonKitapBilgiGuncelle.Text = "Kitap bilgi güncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(112, 234);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(100, 39);
            buttonKitapEkle.TabIndex = 11;
            buttonKitapEkle.Text = "Yeni kitap ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(98, 199);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(100, 23);
            textBoxKitapTurKodu.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(98, 162);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(100, 23);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Location = new Point(98, 127);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(100, 23);
            textBoxYazarSoyadi.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(98, 96);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(100, 23);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(98, 59);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(100, 23);
            textBoxKitapAdi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 199);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Kitap Tür Kodu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 127);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Yazar Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitabiOduncVer);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Location = new Point(419, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 257);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitabiOduncVer
            // 
            buttonKitabiOduncVer.Location = new Point(107, 138);
            buttonKitabiOduncVer.Name = "buttonKitabiOduncVer";
            buttonKitabiOduncVer.Size = new Size(100, 39);
            buttonKitabiOduncVer.TabIndex = 21;
            buttonKitabiOduncVer.Text = "Kitabı Ödünç Ver";
            buttonKitabiOduncVer.UseVisualStyleBackColor = true;
            buttonKitabiOduncVer.Click += buttonKitabiOduncVer_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 104);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 15;
            label9.Text = "Tarih";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 62);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 13;
            label8.Text = "Ödünç Alan";
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(107, 54);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(137, 23);
            textBoxOduncAlan.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(labelgecikmebedeli);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(716, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 257);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap Iade";
            // 
            // button2
            // 
            button2.Location = new Point(39, 162);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 20;
            button2.Text = "Kitabı iade et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 104);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 13;
            button1.Text = "Gecikme Bedeli hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(145, 54);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 19;
            label12.Text = "TL";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelgecikmebedeli
            // 
            labelgecikmebedeli.AutoSize = true;
            labelgecikmebedeli.Location = new Point(126, 54);
            labelgecikmebedeli.Name = "labelgecikmebedeli";
            labelgecikmebedeli.Size = new Size(13, 15);
            labelgecikmebedeli.TabIndex = 18;
            labelgecikmebedeli.Text = "0";
            labelgecikmebedeli.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 54);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 17;
            label10.Text = "Gecikme Bedeli:";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Location = new Point(12, 332);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.Size = new Size(1053, 221);
            dataGridViewKitaplar.TabIndex = 3;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 314);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 4;
            label7.Text = "Kitap Listesi";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1077, 565);
            Controls.Add(label7);
            Controls.Add(dataGridViewKitaplar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label8;
        private TextBox textBoxOduncAlan;
        private DataGridView dataGridViewKitaplar;
        private Label label7;
        private Label labelgecikmebedeli;
        private Label label10;
        private Button button2;
        private Button button1;
        private Label label12;
        private Label kitapid;
        private Button buttonKitabiOduncVer;
        private Button buttonara;
    }
}