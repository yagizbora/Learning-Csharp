namespace YoutubeDownloader
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
            txtUrl = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            txtPath = new TextBox();
            label2 = new Label();
            btnDownload = new Button();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(25, 31);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(175, 23);
            txtUrl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "VideoUrl";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 133);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(432, 23);
            progressBar1.TabIndex = 2;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(258, 31);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(186, 23);
            txtPath.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Path";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(25, 60);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(100, 23);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "Video İndir";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(258, 60);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Dosya yolu seç";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 168);
            Controls.Add(btnBrowse);
            Controls.Add(btnDownload);
            Controls.Add(label2);
            Controls.Add(txtPath);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(txtUrl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Label label1;
        private ProgressBar progressBar1;
        private TextBox txtPath;
        private Label label2;
        private Button btnDownload;
        private Button btnBrowse;
    }
}
