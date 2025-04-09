/*
Вычислить сумму 1 + 1/1! + 1/2! + 1/3! + … +1/n!. Для вычисления
факториала использовать метод созданный в задаче 5.
*/

namespace задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(SumRecF(n));
        }

        static double SumRecF(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / F(i);
            }
            return sum + 1;
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
