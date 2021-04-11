using System;

namespace HomeWork2._7b
{
    class Program
    {
        // Суханов.
        // 7 задание. б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        static int Sum(int a, int b)     // Опсание рекурсивного метода для подсчёта суммы чисел от a до b. 
        {
            if (a == b)
            {
                return b;
            }
            else
            {
                return a + Sum(a + 1, b);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число, которое больше первого: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int SumNum = Sum(a, b); // С горем пополам, но разобрался в этом методе

            Console.WriteLine($"Сумма чисел равняется {SumNum}.");
        }
    }
}
