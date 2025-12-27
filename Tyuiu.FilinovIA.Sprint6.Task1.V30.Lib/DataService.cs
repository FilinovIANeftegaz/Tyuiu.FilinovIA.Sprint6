using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilinovIA.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) - 2*x) == 0)
                    valueArray[c] = 0.00;
                else
                    valueArray[c] = Math.Round((2*x-3)/(Math.Cos(x)-2*x)+5*x-6, 2);
                c++;
            }

            return valueArray;
        }
    }
}
