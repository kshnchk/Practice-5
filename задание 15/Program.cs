/*
Создать метод, который получает число предметов и
запрашивает массу каждого, а затем возвращает среднюю массу.
*/

namespace задание_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов: ");
            int num = int.Parse(Console.ReadLine());


            double a = Calс(num);
            Console.WriteLine($"Средняя масса: {a}");
        }

        static double Calс(int num)
        {
            double M = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Введите массу предмета {i}: ");
                double mass = double.Parse(Console.ReadLine());
                M += mass;
            }

            return M / num;
        }
    }
}
