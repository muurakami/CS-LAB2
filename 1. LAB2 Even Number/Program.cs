﻿// 1. Определите, является ли введенное число четным. 


class Program
{
    static void Main()
    {
        // Объявляем переменную для хранения введенного числа
        int number;

        // Выводим сообщение, чтобы пользователь ввел число
        Console.Write("Введите целое число: ");

        // Считываем введенное пользователем значение и преобразуем его в целое число (int)
        number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, является ли число четным
        if (number % 2 == 0)
        {
            Console.WriteLine("Введенное число является чётным.");
        }
        else
        {
            Console.WriteLine("Введенное число нечётное.");
        }

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}