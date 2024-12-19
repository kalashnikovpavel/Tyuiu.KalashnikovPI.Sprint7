namespace Tyuiu.KalashnikovPI.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_KPI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void openFileDialogProjfunc_KPI()
        {
            // ������� ��������� OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // ������������� �������� ����������� ����
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "�������� ����";

                // ��������� ���������� ���� � ���������, ��� �� ������ ����
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // �������� ���� � ���������� �����
                    string selectedFilePath = openFileDialog.FileName;

                    // ����� �� ������ �������� ��� ��� ��������� ���������� �����
                    MessageBox.Show("��������� ����: " + selectedFilePath);
                }
            }
        }

        private void buttonRead_KPI_Click(object sender, EventArgs e)
        {
            openFileDialogProjfunc_KPI();
        }

        private void buttonRead_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "�������";
        }
    }
}
