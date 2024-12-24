using System.Data;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KalashnikovPI.Project.V6.Lib;

namespace Tyuiu.KalashnikovPI.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_KPI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


        private void buttonRead_KPI_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string[,] arrayValues = ds.LoadFromFileData(filePath);

                        DataTable dataTable = new DataTable();

                        dataTable.Columns.Add("Номер");
                        dataTable.Columns.Add("ФИО");
                        dataTable.Columns.Add("Дата рождения пациента");
                        dataTable.Columns.Add("Диагноз");
                        dataTable.Columns.Add("Необходимо ли амбулаторное лечение");
                        dataTable.Columns.Add("Срок потери трудоспособности");
                        dataTable.Columns.Add("Состоит ли на диспансерном учете");
                        dataTable.Columns.Add("Примечание");
                        dataTable.Columns.Add("ФИО Врача");
                        dataTable.Columns.Add("Должность и специализация");


                        for (int i = 0; i < arrayValues.GetLength(0); i++)
                        {
                            DataRow row = dataTable.NewRow();
                            for (int j = 0; j < arrayValues.GetLength(1); j++)
                            {
                                row[j] = arrayValues[i, j];
                            }
                            dataTable.Rows.Add(row);
                        }
                        dataGridViewRes_KPI.DataSource = dataTable;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Ошибка формата: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
            }
            buttonSave_KPI.Enabled = true;
        }

        private void buttonRead_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "Открыть";
        }

        private void buttonEdit_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "zulu";
        }

        private void buttonSave_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "Сохранить";
        }

        private void buttonInfo_KPI_MouseEnter(Object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "Информация";
        }

        private void buttonEdit_KPI_Click(object sender, EventArgs e)
        {
            dataGridViewRes_KPI.ReadOnly = false;
        }

        private void buttonSave_KPI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogProj_KPI.FileName = "OutputFile.csv";
                openFileDialogProj_KPI.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialogProj_KPI.ShowDialog();

                if (openFileDialogProj_KPI.ShowDialog() == DialogResult.OK)
                {
                    string savePath = openFileDialogProj_KPI.FileName;
  
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }

                    int rows = dataGridViewRes_KPI.RowCount;
                    int columns = dataGridViewRes_KPI.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            string cellValue = dataGridViewRes_KPI.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                            cellValue = cellValue.Replace("\"", "\"\"");

                            strBuilder.Append($"\"{cellValue}\"");

                            if (j != columns - 1)
                            {
                                strBuilder.Append(","); 
                            }
                        }
                        strBuilder.AppendLine(); 
                    }
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("nigger", "akdfjhasdfkljh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
}
