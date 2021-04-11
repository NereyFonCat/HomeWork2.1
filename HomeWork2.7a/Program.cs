using System;

namespace HomeWork2._7
{
    class Program
    {

        // Суханов
        // 7 Задание. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).


        static int Numbers(int a, int b)     // Метод для вывода чисел от a до b. Если можно было сделать программу прощу, подскажите, как.
        {

            if (a < b)
            {
                Console.Write($"{a}, ");
                return Numbers(a + 1, b);
            }
            else
            {
                Console.Write($"{a}.");
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число, которое больше первого: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Numbers(a, b);
        }
    }
}
