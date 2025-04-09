/*
Создать метод возвращающий число, переведённое из
десятичной системы счисления (СС) в указанную СС (не старше 10).
Например, СС двоичная, значит номер 2.
*/

namespace задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Conv(10, 2));
        }

        static string Conv(int num, int bNum)
        {

            if (bNum < 2 || bNum > 10)
            {
                return "Основание должно быть от 2 до 10.";
            }

            string res = "";
            if (num == 0) return "0";

            while (num > 0)
            {
                int r = num % bNum;
                res = r.ToString() + res;
                num /= bNum;
            }

            return res;
        }
    }
}
