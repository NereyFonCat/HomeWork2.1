using System;

namespace HomeWork2._6
{
    class Program
    {
        static int NumSum(int n)
        {
            int s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            return s;
        }
        static void Main(string[] args)
        {
            // Суханов
            // Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            // «Хорошим» называется число, которое делится на сумму своих цифр.
            // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

            DateTime start = DateTime.Now;
            int quantity = 0;

            for (var i = 1; i < 1000000000; i++)
            {
                if (i % NumSum(i) == 0)
                {
                    quantity++;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до 1 000 000 000: {quantity}.");
            Console.WriteLine(finish - start); //Данная задача понятна. Вопросов не имею. 
        }
    }
}
