using System;

namespace HomeWork2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Суханов
            //Написать метод подсчета количества цифр числа.

            CountNum();
        }

        private static void CountNum()
        {
            Console.Write("Введите любое число: ");
            var Num = Console.ReadLine();

            int i = 0;

            // Использовал оператор foreach, он для меня более удобен в подсчёте цифр оказался,
            // тем более он не считает знаки препинания в десятичных числах.
            // Если это грубое применение, сообщите об этом, пожалуйста. 

            foreach (int NumEach in Num)
            {
                i++;
            }
            Console.WriteLine($"В введённом числе {i} цифр");
        }
    }
}
