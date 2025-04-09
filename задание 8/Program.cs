/*
Создать метод возвращающий сумму: x + x3/3 + … + x11/11.
Условный оператор и операцию возведения в степень не использовать.
*/

namespace задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2.0;
            Console.WriteLine(Sum(x));
        }

        static double Sum(double x)
        {
            double sum = 0.0;
            double t = x;

            for (int i = 1; i <= 11; i += 2)
            {
                sum += t / i;
                t *= x * x;
            }

            return sum;
        }
    }
}
