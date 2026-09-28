using Tyuiu.UsoltsevME.Sprint1.Task3.V12.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите катет A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите катет B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Катет А треугольника = " + a);
            Console.WriteLine("Катет В треугольника = " + b);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Площадь треугольника - " + ds.TriangleArea(a, b));

            Console.ReadKey();
        }
    }
}
