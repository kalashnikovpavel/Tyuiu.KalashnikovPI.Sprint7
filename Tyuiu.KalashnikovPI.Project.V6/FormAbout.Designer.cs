namespace Tyuiu.KalashnikovPI.Project.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOk_KPI = new Button();
            textBoxInfo_KPI = new TextBox();
            pictureBoxAbout_KPI = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KPI).BeginInit();
            SuspendLayout();
            // 
            // buttonOk_KPI
            // 
            buttonOk_KPI.Location = new Point(264, 153);
            buttonOk_KPI.Name = "buttonOk_KPI";
            buttonOk_KPI.Size = new Size(75, 23);
            buttonOk_KPI.TabIndex = 0;
            buttonOk_KPI.Text = "Ок";
            buttonOk_KPI.UseVisualStyleBackColor = true;
            buttonOk_KPI.Click += button1_Click;
            // 
            // textBoxInfo_KPI
            // 
            textBoxInfo_KPI.Location = new Point(50, 12);
            textBoxInfo_KPI.Multiline = true;
            textBoxInfo_KPI.Name = "textBoxInfo_KPI";
            textBoxInfo_KPI.ReadOnly = true;
            textBoxInfo_KPI.Size = new Size(289, 135);
            textBoxInfo_KPI.TabIndex = 1;
            textBoxInfo_KPI.Text = "Разрабочик: Калашников П. И.\r\nГруппа: СМАРТб-24-1\r\n\r\nПрограмма создана в целях изучения языка С#\r\n\r\nТюменский Индустриальный Университет(с) 2024\r\nВысшая Школа Цифровых Технологий(с) 2024\r\n";
            // 
            // pictureBoxAbout_KPI
            // 
            pictureBoxAbout_KPI.Image = (Image)resources.GetObject("pictureBoxAbout_KPI.Image");
            pictureBoxAbout_KPI.Location = new Point(12, 12);
            pictureBoxAbout_KPI.Name = "pictureBoxAbout_KPI";
            pictureBoxAbout_KPI.Size = new Size(32, 35);
            pictureBoxAbout_KPI.TabIndex = 2;
            pictureBoxAbout_KPI.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 193);
            Controls.Add(pictureBoxAbout_KPI);
            Controls.Add(textBoxInfo_KPI);
            Controls.Add(buttonOk_KPI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_KPI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk_KPI;
        private TextBox textBoxInfo_KPI;
        private PictureBox pictureBoxAbout_KPI;
    }
}