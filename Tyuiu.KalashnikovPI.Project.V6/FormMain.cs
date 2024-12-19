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
            // Создаем экземпляр OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Устанавливаем свойства диалогового окна
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл";

                // Открываем диалоговое окно и проверяем, был ли выбран файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь к выбранному файлу
                    string selectedFilePath = openFileDialog.FileName;

                    // Здесь вы можете добавить код для обработки выбранного файла
                    MessageBox.Show("Выбранный файл: " + selectedFilePath);
                }
            }
        }

        private void buttonRead_KPI_Click(object sender, EventArgs e)
        {
            openFileDialogProjfunc_KPI();
        }

        private void buttonRead_KPI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KPI.ToolTipTitle = "Открыть";
        }
    }
}
