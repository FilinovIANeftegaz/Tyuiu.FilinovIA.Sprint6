using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilinovIA.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0;j< cols; j++)
                {
                    if (j==rows-1)
                    {
                        if (Convert.ToInt32(line_r[j]) < 2)
                        {
                            arrayValues[i, j] = 2;
                        } else
                        {
                            arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                        }
                    }else
                    {
                        arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                    }
                }
            }
            return arrayValues;
        }
    }
}
