using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.UsoltsevME.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double result = Math.Pow(1 - Math.Tan(x), Math.Cos(x) / Math.Sin(x))
                + Math.Cos(x - y);

            result = Math.Round(result, 3);

            return result;
        }
    }
}