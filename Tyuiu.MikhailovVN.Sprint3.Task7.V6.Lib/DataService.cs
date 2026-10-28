
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailovVN.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                
                if ((4 * x - 0.5) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (3 * Math.Cos(x)) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
