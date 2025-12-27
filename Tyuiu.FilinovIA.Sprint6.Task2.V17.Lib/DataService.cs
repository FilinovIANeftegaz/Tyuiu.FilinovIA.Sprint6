using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilinovIA.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                valueArray[c] = Math.Round((Math.Cos(x)) + (4 * x / 2) - (Math.Sin(x) * 3 * x), 2);
                c++;
            }

            return valueArray;
        }
    }
}
