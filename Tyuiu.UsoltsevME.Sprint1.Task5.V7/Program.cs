using Tyuiu.UsoltsevME.Sprint1.Task5.V7.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите f: ");
            double f = Convert.ToDouble(Console.ReadLine());

            if (f < 0 || f >= 360)
            {
                Console.WriteLine("Ошибка: f должно быть от 0 до 360.");
            }
            else
            {
                int result = ds.AngleToHoursMinutes(f);

                Console.WriteLine("****************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
                Console.WriteLine("****************************************************");

                Console.WriteLine("Количество полных часов = " + result);
            }

            Console.ReadKey();
        }
    }
}