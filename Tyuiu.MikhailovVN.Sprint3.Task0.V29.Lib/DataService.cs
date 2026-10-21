
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailovVN.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 05;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sum = sum + (Math.Pow(value,2 * i) + 1.0 / (i + 1)) * Math.Cos(value);
            }

            return Math.Round(sum, 3);
        }
    }
}
