using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilinovIA.Sprint6.Task4.V12.Lib
{
    public class DataService : ISprint6Task4V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((3*x+0.5)==0)
                    valueArray[c] = 0.00;
                else
                    valueArray[c] = Math.Round(Math.Sin(x)+(2/(3*x+0.5))-2*Math.Cos(x)*2*x, 2);
                c++;
            }

            return valueArray;
        }
    }
}
