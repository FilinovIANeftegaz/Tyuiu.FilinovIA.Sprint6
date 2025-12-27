using Tyuiu.FilinovIA.Sprint6.Task0.V2.Lib;

namespace Tyuiu.FilinovIA.Sprint6.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService(); 
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 6.425;
            Assert.AreEqual(res, wait);
        }
    }
}
