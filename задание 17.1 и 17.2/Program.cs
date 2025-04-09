/*
Начав тренировки, лыжник в первый день пробежал 10 км.
Каждый следующий день он увеличивал пробег на 10% от пробега
предыдущего дня. Создать метод возвращающий:
1. пробег лыжника за N-ый день тренировок;
2. суммарный путь за первые N дней тренировок.
*/

namespace задание_17._1_и_17._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество дней N: ");

            int n = int.Parse(Console.ReadLine());
            double d = G(n);
            double t = S(n);

            Console.WriteLine($"Пробег лыжника за {n}-й день тренировок: {d:F2} км.");
            Console.WriteLine($"Суммарный путь за первые {n} дней тренировок: {t:F2} км.");
        }

        static double G(int n)
        {
            double i = 10;
            double r = 0.1;
            return i * Math.Pow(1 + r, n - 1);
        }

        static double S(int n)
        {
            double s = 0;
            double i = 10;
            double r = 0.1;


            for (int j = 0; j < n; j++)
            {
                s += i * Math.Pow(1 + r, j);
            }

            return s;
        }
    }
}
