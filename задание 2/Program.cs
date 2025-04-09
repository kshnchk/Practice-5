/*
Создать метод возвращающий факториал числа (k!), где k! = 1 · 2 · 3…· k.
*/

namespace задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            Console.WriteLine($"Факториал {k}! = {F(k)}");
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
