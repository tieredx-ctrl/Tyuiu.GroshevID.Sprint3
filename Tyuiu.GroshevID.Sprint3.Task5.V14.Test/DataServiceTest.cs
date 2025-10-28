﻿using Tyuiu.GroshevID.Sprint3.Task5.V14.Lib;

namespace Tyuiu.GroshevID.Sprint3.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = -31.275;
            Assert.AreEqual(wait, res);
        }
    }
}
