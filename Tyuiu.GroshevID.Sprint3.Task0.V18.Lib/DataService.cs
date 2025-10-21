using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GroshevID.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 0;

            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multiplySeries += Math.Pow(2 / (Math.Cos(value) + 0.5), startValue);
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
