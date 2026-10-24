
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailovVN.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSum = 1.0;

            while (startValue <= stopValue)
            {
                multSum = multSum * (Math.Cos(0.1) + Math.Pow(startValue, -2));
                startValue++;
            }
            return Math.Round(multSum, 3);
        }
    }
}
