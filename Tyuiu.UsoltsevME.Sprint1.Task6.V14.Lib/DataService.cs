using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.UsoltsevME.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            if (value.Length == 0)
            {
                return false;
            }

            foreach (char c in value)
            {
                if (!((c >= 'а' && c <= 'я') || c == 'ё'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}