/*
Создать метод, который определяет через сколько месяцев
гражданин накопит необходимую ему сумму рублей, если он в начале
месяца открыл счет в банке, вложив N рублей. Через каждый месяц
размер вклада увеличивается на установленный банком % от
имеющейся суммы.
Метод должен включать в себя 3 параметра: вклад, процент и
необходимая сумма.
*/

namespace задание_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите N рублей: ");
            double n = double.Parse(Console.ReadLine());


            Console.Write("Введите процент (например, 0,02 для 2%): ");
            double p = double.Parse(Console.ReadLine());


            Console.Write("Введите необходимую сумму: ");
            double t = double.Parse(Console.ReadLine());


            int m = Calc(n, p, t);
            Console.WriteLine($"Гражданин накопит {t} рублей через {m} месяцев.");
        }

        static int Calc(double d, double r, double g)
        {
            int m = 0;

            while (d < g)
            {
                d += d * r;
                m++;
            }

            return m;
        }
    }
}
