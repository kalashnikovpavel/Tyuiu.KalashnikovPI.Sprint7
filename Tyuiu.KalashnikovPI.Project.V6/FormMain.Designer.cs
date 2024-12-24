namespace Tyuiu.KalashnikovPI.Project.V6
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_KPI = new Panel();
            groupBoxTop = new GroupBox();
            buttonRead_KPI = new Button();
            buttonSave_KPI = new Button();
            buttonInfo_KPI = new Button();
            buttonEdit_KPI = new Button();
            panelBtootm_KPI = new Panel();
            groupBoxBottom = new GroupBox();
            dataGridViewRes_KPI = new DataGridView();
            toolTipInfo_KPI = new ToolTip(components);
            openFileDialogProj_KPI = new OpenFileDialog();
            saveFileDialogProj_KPI = new SaveFileDialog();
            panelTop_KPI.SuspendLayout();
            groupBoxTop.SuspendLayout();
            panelBtootm_KPI.SuspendLayout();
            groupBoxBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_KPI).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KPI
            // 
            panelTop_KPI.Controls.Add(groupBoxTop);
            panelTop_KPI.Dock = DockStyle.Top;
            panelTop_KPI.Location = new Point(0, 0);
            panelTop_KPI.Name = "panelTop_KPI";
            panelTop_KPI.Size = new Size(834, 93);
            panelTop_KPI.TabIndex = 0;
            // 
            // groupBoxTop
            // 
            groupBoxTop.Controls.Add(buttonRead_KPI);
            groupBoxTop.Controls.Add(buttonSave_KPI);
            groupBoxTop.Controls.Add(buttonInfo_KPI);
            groupBoxTop.Controls.Add(buttonEdit_KPI);
            groupBoxTop.Dock = DockStyle.Top;
            groupBoxTop.Location = new Point(0, 0);
            groupBoxTop.Name = "groupBoxTop";
            groupBoxTop.Size = new Size(834, 87);
            groupBoxTop.TabIndex = 0;
            groupBoxTop.TabStop = false;
            groupBoxTop.Text = "Управление";
            // 
            // buttonRead_KPI
            // 
            buttonRead_KPI.Image = (Image)resources.GetObject("buttonRead_KPI.Image");
            buttonRead_KPI.Location = new Point(190, 22);
            buttonRead_KPI.Name = "buttonRead_KPI";
            buttonRead_KPI.Size = new Size(86, 59);
            buttonRead_KPI.TabIndex = 3;
            toolTipInfo_KPI.SetToolTip(buttonRead_KPI, "Открыть файл с диска");
            buttonRead_KPI.UseVisualStyleBackColor = true;
            buttonRead_KPI.Click += buttonRead_KPI_Click;
            buttonRead_KPI.MouseEnter += buttonRead_KPI_MouseEnter;
            // 
            // buttonSave_KPI
            // 
            buttonSave_KPI.Enabled = false;
            buttonSave_KPI.Image = (Image)resources.GetObject("buttonSave_KPI.Image");
            buttonSave_KPI.Location = new Point(98, 22);
            buttonSave_KPI.Name = "buttonSave_KPI";
            buttonSave_KPI.Size = new Size(86, 59);
            buttonSave_KPI.TabIndex = 2;
            toolTipInfo_KPI.SetToolTip(buttonSave_KPI, "Сохранить файл на диск");
            buttonSave_KPI.UseVisualStyleBackColor = true;
            buttonSave_KPI.Click += buttonSave_KPI_Click;
            buttonSave_KPI.MouseEnter += buttonSave_KPI_MouseEnter;
            // 
            // buttonInfo_KPI
            // 
            buttonInfo_KPI.Dock = DockStyle.Right;
            buttonInfo_KPI.Image = (Image)resources.GetObject("buttonInfo_KPI.Image");
            buttonInfo_KPI.Location = new Point(745, 19);
            buttonInfo_KPI.Name = "buttonInfo_KPI";
            buttonInfo_KPI.Size = new Size(86, 65);
            buttonInfo_KPI.TabIndex = 1;
            toolTipInfo_KPI.SetToolTip(buttonInfo_KPI, "О приложении");
            buttonInfo_KPI.UseVisualStyleBackColor = true;
            buttonInfo_KPI.Click += buttonInfo_KPI_Click;
            buttonInfo_KPI.MouseEnter += buttonInfo_KPI_MouseEnter;
            // 
            // buttonEdit_KPI
            // 
            buttonEdit_KPI.Image = (Image)resources.GetObject("buttonEdit_KPI.Image");
            buttonEdit_KPI.Location = new Point(6, 22);
            buttonEdit_KPI.Name = "buttonEdit_KPI";
            buttonEdit_KPI.Size = new Size(86, 59);
            buttonEdit_KPI.TabIndex = 0;
            toolTipInfo_KPI.SetToolTip(buttonEdit_KPI, "Редактировать таблицу");
            buttonEdit_KPI.UseVisualStyleBackColor = true;
            buttonEdit_KPI.Click += buttonEdit_KPI_Click;
            buttonEdit_KPI.MouseEnter += buttonEdit_KPI_MouseEnter;
            // 
            // panelBtootm_KPI
            // 
            panelBtootm_KPI.Controls.Add(groupBoxBottom);
            panelBtootm_KPI.Dock = DockStyle.Fill;
            panelBtootm_KPI.Location = new Point(0, 93);
            panelBtootm_KPI.Name = "panelBtootm_KPI";
            panelBtootm_KPI.Size = new Size(834, 368);
            panelBtootm_KPI.TabIndex = 1;
            // 
            // groupBoxBottom
            // 
            groupBoxBottom.Controls.Add(dataGridViewRes_KPI);
            groupBoxBottom.Dock = DockStyle.Fill;
            groupBoxBottom.Location = new Point(0, 0);
            groupBoxBottom.Name = "groupBoxBottom";
            groupBoxBottom.Size = new Size(834, 368);
            groupBoxBottom.TabIndex = 0;
            groupBoxBottom.TabStop = false;
            groupBoxBottom.Text = "Данные";
            // 
            // dataGridViewRes_KPI
            // 
            dataGridViewRes_KPI.AllowUserToAddRows = false;
            dataGridViewRes_KPI.AllowUserToDeleteRows = false;
            dataGridViewRes_KPI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_KPI.Dock = DockStyle.Fill;
            dataGridViewRes_KPI.Location = new Point(3, 19);
            dataGridViewRes_KPI.Name = "dataGridViewRes_KPI";
            dataGridViewRes_KPI.ReadOnly = true;
            dataGridViewRes_KPI.Size = new Size(828, 346);
            dataGridViewRes_KPI.TabIndex = 0;
            // 
            // toolTipInfo_KPI
            // 
            toolTipInfo_KPI.IsBalloon = true;
            toolTipInfo_KPI.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(panelBtootm_KPI);
            Controls.Add(panelTop_KPI);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 6 | Калашников П. И.";
            panelTop_KPI.ResumeLayout(false);
            groupBoxTop.ResumeLayout(false);
            panelBtootm_KPI.ResumeLayout(false);
            groupBoxBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_KPI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KPI;
        private Panel panelBtootm_KPI;
        private GroupBox groupBoxTop;
        private Button buttonEdit_KPI;
        private GroupBox groupBoxBottom;
        private Button buttonInfo_KPI;
        private Button buttonRead_KPI;
        private Button buttonSave_KPI;
        private ToolTip toolTipInfo_KPI;
        private DataGridView dataGridViewRes_KPI;
        private OpenFileDialog openFileDialogProj_KPI;
        private SaveFileDialog saveFileDialogProj_KPI;
    }
}
