using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GroshevID.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += (Math.Sin(x) + 2 / k);
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
