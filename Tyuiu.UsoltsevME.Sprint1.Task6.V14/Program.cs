using Tyuiu.UsoltsevME.Sprint1.Task6.V14.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите строку: ");
            string value = Console.ReadLine();

            bool result = ds.CheckLowerCaseRusLetters(value);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            if (result)
            {
                Console.WriteLine("Строка состоит только из строчных русских букв.");
            }
            else
            {
                Console.WriteLine("Строка содержит символы, которые не являются строчными русскими буквами.");
            }

            Console.ReadKey();
        }
    }
}