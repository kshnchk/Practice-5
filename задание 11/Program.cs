/*
Создать программу перевода целого числа из указанной СС в десятичную СС.
*/

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num1 = "1010";
            int bNum1 = 2;
            Console.WriteLine($"{num1} в {bNum1} системе = {Conv(num1, bNum1)} (ожидается 10)");
        }
        static int Conv(string num, int bNum)
        {

            if (bNum < 2 || bNum > 10)
            {
                return -1;
            }

            int d = 0;
            int p = 1;


            for (int i = num.Length - 1; i >= 0; i--)
            {
                int digit = (int)(num[i] - '0');
                if (digit < 0 || digit >= bNum)
                {
                    return -1;
                }

                d += digit * p;
                p *= bNum;
            }

            return d;
        }
    }
}
