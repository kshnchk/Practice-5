/*
Создать метод, который из оценок ученика по 10 предметам определяет среднюю оценку.
*/

namespace задание_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Cal();
            Console.WriteLine($"Средняя оценка: {a}");
        }

        static double Cal()
        {
            double sum = 0;
            int num = 10;
            Console.WriteLine("Введите оценки по 10 предметам:");

            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Оценка за предмет {i}: ");
                double g = double.Parse(Console.ReadLine());
                sum += g;
            }

            return sum / num;
        }
    }
}
