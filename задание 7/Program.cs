/*
Создать метод возвращающий сумму 1 — 1/2 + 1/3 + … + (-1)n+1/n. 
Условный оператор и операцию возведения в степень не использовать.
*/

namespace задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(AltSum(n));
        }

        static double AltSum(int n)
        {
            double sum = 0;
            double l = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += l * (1.0 / i);
                l = -l;
            }
            return sum;
        }

    }
}
