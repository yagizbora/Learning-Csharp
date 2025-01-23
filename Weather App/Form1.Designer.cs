namespace Weather_App
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
            Fetchdata = new Button();
            Weather_Status = new ListView();
            city = new TextBox();
            SuspendLayout();
            // 
            // Fetchdata
            // 
            Fetchdata.AccessibleName = "Fetch_Data";
            Fetchdata.Location = new Point(568, 12);
            Fetchdata.Name = "Fetchdata";
            Fetchdata.Size = new Size(102, 51);
            Fetchdata.TabIndex = 0;
            Fetchdata.Text = "Tıkla";
            Fetchdata.UseVisualStyleBackColor = true;
            Fetchdata.Click += button1_Click;
            // 
            // Weather_Status
            // 
            Weather_Status.Location = new Point(12, 70);
            Weather_Status.Margin = new Padding(4);
            Weather_Status.MinimumSize = new Size(100, 100);
            Weather_Status.Name = "Weather_Status";
            Weather_Status.Size = new Size(670, 209);
            Weather_Status.TabIndex = 1;
            Weather_Status.UseCompatibleStateImageBehavior = false;
            Weather_Status.DrawColumnHeader += Weather_Status_DrawColumnHeader;
            Weather_Status.DrawItem += Weather_Status_DrawItem;
            Weather_Status.DrawSubItem += Weather_Status_DrawSubItem;
            // 
            // city
            // 
            city.BackColor = SystemColors.Window;
            city.ForeColor = SystemColors.WindowText;
            city.Location = new Point(221, 12);
            city.Multiline = true;
            city.Name = "city";
            city.Size = new Size(214, 51);
            city.TabIndex = 2;
            city.TextChanged += TextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 324);
            Controls.Add(Fetchdata);
            Controls.Add(city);
            Controls.Add(Weather_Status);
            Name = "Form1";
            Text = "Weather App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Fetchdata;
        private ListView Weather_Status;
        private TextBox city;
    }
}
