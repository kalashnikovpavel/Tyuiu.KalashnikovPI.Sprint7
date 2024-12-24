using System.Text;

namespace Tyuiu.KalashnikovPI.Project.V6.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filepath)
        {
            // Проверка
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Файл не найден.", filepath);
            }


            string[] lines = File.ReadAllLines(filepath);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length; 

            string[,] data = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                if (values.Length != columns)
                {
                    throw new FormatException("Некорректный формат данных в строке: " + lines[i]);
                }

                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = values[j];
                }
            }

            return data;
        }
    }

}
