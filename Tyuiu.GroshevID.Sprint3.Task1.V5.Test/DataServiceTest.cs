using Tyuiu.GroshevID.Sprint3.Task1.V5.Lib;

namespace Tyuiu.GroshevID.Sprint3.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 3.195;

            Assert.AreEqual(wait, res);
        }
    }
}
