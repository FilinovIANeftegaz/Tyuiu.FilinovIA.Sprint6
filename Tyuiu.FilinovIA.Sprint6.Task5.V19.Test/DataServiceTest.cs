using Tyuiu.FilinovIA.Sprint6.Task5.V19.Lib;
namespace Tyuiu.FilinovIA.Sprint6.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            double[] wait = new double[] {1, 5,8,9};
            double[] res = ds.LoadFromDataFile(@"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutFileTask5V19.txt");
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
