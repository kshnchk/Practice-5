/*
Создать метод возвращающий сумму 1! + 2! + 3! + … + n!. Для
вычисления факториала использовать метод созданный в задаче 5.
*/

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(SumF(n));
        }

        static long SumF(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += F(i);
            }
            return sum;
        }

        static long F(int k)
        {
            if (k == 0) return 1;
            long res = 1;
            for (int i = 1; i <= k; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
