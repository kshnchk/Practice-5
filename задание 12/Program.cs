/*
Создать метод принимающий число в диапазоне от 1 до 100
включительно. Если пользователь вводит число вне этого диапазона,
программа должна повторно запрашивать его до тех пор, пока не
будет введено корректное число. После этого программа должна
вывести введенное число.
*/

namespace задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = GetNumberInRange();
            Console.WriteLine($"Вы ввели число: {num}");
        }

        static int GetNumberInRange()
        {
            int num;

            do
            {
                Console.WriteLine("Введите число от 1 до 100:");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 100);

            return num;
        }
    }
}
