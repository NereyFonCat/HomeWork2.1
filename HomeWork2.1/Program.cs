using System;

namespace HomeWork2._1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Суханов 
            //Написать метод, возвращающий минимальное из трёх чисел.

            MinNum();
        }

        private static void MinNum()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Провёл проверку минимального из чисел через цикл if

            if (a < b && a < c)
            {
                Console.WriteLine($"Минимальное из трёх числе {a}");
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine($"Минимальное из трёх числе {b}");
                }
                else Console.WriteLine($"Минимальное из трёх числе {c}");
            }
        }
    }
}
