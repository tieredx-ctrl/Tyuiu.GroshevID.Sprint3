using Tyuiu.GroshevID.Sprint3.Task0.V18.Lib;

namespace Tyuiu.GroshevID.Sprint3.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int x = 1;
            int k1 = 1;
            int k2 = 6;

            double res = ds.GetMultiplySeries(x, k1, k2);

            double wait = 914700.94;

            Assert.AreEqual(wait, res);
        }
    }
}
