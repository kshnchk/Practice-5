/*
Создать метод, который печатает ряд чисел M длины N (N – число
вводимое с клавиатуры) в виде: 20 20 20 20 20 20 20 20 20 20 (M = 20, N = 10).
*/

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNums(20, 10);
        }

        static void PrintNums(int M, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(M + " ");
            }
            Console.WriteLine();
        }

    }
}
