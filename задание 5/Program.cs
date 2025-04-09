/*
Создать метод возвращающий натуральное число в квадрате, учитывая следующую закономерность:
12 = 1, 22 = 1 + 3, 32 = 1 + 3 + 5, 42 = 1 + 3 + 5 + 7, …, n2 = 1 + 3 + 5 + 7 + 9 + … + (2n — 1).
*/

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(Sq(n));
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
