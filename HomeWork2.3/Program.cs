using System;

namespace HomeWork2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Суханов
            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            int Sum = 0; // Создал переменную для подсчёта суммы
            int Num;     // Ввёл переменную вне цикла, чтобы она работала в каждой структуре (Если правильно понял)

            do
            {
                Console.Write("Введите любое число или 0 для получения результата: ");
                Num = Convert.ToInt32(Console.ReadLine());

                if (Num > 0 && Num % 2 != 0)
                {
                    Sum = Sum + Num;
                }
            } while (Num != 0);

            Console.WriteLine($"Сумма всех введённых нечётных положительных чисел равна {Sum}");
        }
    }
}
