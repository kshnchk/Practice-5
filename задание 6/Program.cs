/*
Создать метод возвращающий сумму 12 + 22 + 32 + … + n2. Операцию
возведения в степень не использовать, а использовать метод
созданный в задаче Error: Reference source not found.
*/

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(SumSq(n));
        }

        static int SumSq(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Sq(i);
            }
            return sum;
        }

        static int Sq(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (2 * i - 1);
            }
            return sum;
        }
    }
}
