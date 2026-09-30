using Tyuiu.UsoltsevME.Sprint1.Task4.V24.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                         *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x <= 0)
            {
                Console.WriteLine("Ошибка: x должен быть больше 0.");
            }
            else
            {

            double result = ds.Calculate(x, y);
            
            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            Console.WriteLine("Lnxy/x+корень2y^2 - " + ds.Calculate(x, y));
            }
            Console.ReadKey();
        }
    }
}
