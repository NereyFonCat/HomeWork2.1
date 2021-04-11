using System;

namespace HomeWork2._4
{
    class Program
    {
        // Суханов.
        // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
        // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.


        private static bool LogPas()               // Создание самого метода понятно. 
        {
            Console.Write("Введите логин: ");
            var log = Console.ReadLine();

            Console.Write("Введите пароль: ");
            var pas = Console.ReadLine();

            return (log == "root" && pas == "GeekBrains");
        }

        static void Main(string[] args)
        {

            int tr = 3;
            do
            {
                if (LogPas() == true)
                {
                    Console.WriteLine("Авторизация прошла упешно.");
                    break;
                }
                else
                {
                    tr--;
                    Console.WriteLine($"Неверный лоиг или пароль. Осталось попыток {tr}.");
                }
            } while (tr != 0);
        }
    }
}
