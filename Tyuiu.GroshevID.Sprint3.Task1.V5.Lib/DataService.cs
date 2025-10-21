using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GroshevID.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries *= (Math.Cos(0.1) + Math.Pow(startValue, -2));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
