using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilinovIA.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            List<double> list = new List<double>();
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;

                }
            }
            numsArray = numsArray.Where(val => val ==Convert.ToInt32(val)).ToArray();
            return numsArray;
        }
    }
}
