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
                openFileDialog.Title = "�������� ���� ��� ��������";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string[,] arrayValues = ds.LoadFromFileData(filePath);

                        DataTable dataTable = new DataTable();

                        dataTable.Columns.Add("�����");
                        dataTable.Columns.Add("���");
                        dataTable.Columns.Add("���� �������� ��������");
                        dataTable.Columns.Add("�������");
                        dataTable.Columns.Add("���������� �� ������������ �������");
                        dataTable.Columns.Add("���� ������ ����������������");
                        dataTable.Columns.Add("������� �� �� ������������ �����");
                        dataTable.Columns.Add("����������");
                        dataTable.Columns.Add("��� �����");
                        dataTable.Columns.Add("��������� � �������������");
                        int startNumber = dataTable.Rows.Count + 1;      

                        // ��������� ����� ������ �� �������
                        for (int i = 0; i < arrayValues.GetLength(0); i++)
                        {
                            DataRow row = dataTable.NewRow();
                            row[0] = startNumber + i; // ������������� ����� ������
                            for (int j = 1; j < arrayValues.GetLength(1); j++) // �������� � 1, ��� ��� 0 - ��� �����
                            {
                                row[j] = arrayValues[i, j - 1]; // �������� j �� 1, ����� ��������������� ��������
                            }
                            dataTable.Rows.Add(row);
                        }


                        dataGridViewRes_KPI.DataSource = dataTable;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("������: " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("������ �������: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("��������� ������: " + ex.Message);
                    }
                }
            }
            buttonSave_KPI.Enabled = true;
        }

        private void buttonRead_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "�������";
        }

        private void buttonEdit_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "zulu";
        }

        private void buttonSave_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "���������";
        }

        private void buttonInfo_KPI_MouseEnter(Object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "����������";
        }

        private void buttonEdit_KPI_Click(object sender, EventArgs e)
        {
            dataGridViewRes_KPI.ReadOnly = false;
        }

        private void buttonSave_KPI_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogProj_KPI.FileName = "Outputfile.csv";
                if (saveFileDialogProj_KPI.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialogProj_KPI.FileName;
                    
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }
                    int rows = dataGridViewRes_KPI.RowCount;
                    int cols = dataGridViewRes_KPI.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            
                            string cellVal = dataGridViewRes_KPI.Rows[i].Cells[j].Value?.ToString() ?? string.Empty; // �������� �� null �������� ������
                            cellVal = cellVal.Replace("\"", "\"\""); // ������ ������� ������ �������� �� ��� ������� ��� CSV 
                            strBuilder.Append($"\"{cellVal}\""); // ����������� �������� � �������

                            // ��������� ����������� ������ ���� ��� �� ��������� ������� � ������
                            if (j != columns - 1)
                            {
                                strBuilder.Append(","); // ��������� �������� �������  
                            }
                        }
                        strBuilder.AppendLine(); // ����� ������ 
                    }
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("���� ������� �������� �� ��� ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"������: {ex.Message}\n���� �� ��� �������� �� ��� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
