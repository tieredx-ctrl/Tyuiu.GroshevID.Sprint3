using Tyuiu.GroshevID.Sprint3.Task4.V20.Lib;

namespace Tyuiu.GroshevID.Sprint3.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 10.483;
            Assert.AreEqual(wait, res);
        }
    }
}
