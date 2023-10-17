// 5. Напишите  программу, которая выводит день недели в зависимости от введенного номера (1-понедельник, 2-вторник …) . При вводе числа, которое больше 7, программа должна выводить сообщение «Такого дня недели не существует».



class Program
{
    static void Main()
    {
        // Выводим сообщение с инструкцией
        Console.WriteLine("Введите номер дня недели (1-понедельник, 2-вторник, ..., 7-воскресенье): ");

        // Считываем введенное пользователем число и преобразуем его в целое число (int)
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что введенное число находится в диапазоне от 1 до 7
        if (dayNumber >= 1 && dayNumber <= 7)
        {
            // Выводим день недели в зависимости от номера
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }
        else
        {
            // Выводим сообщение об ошибке, если введенное число вне диапазона
            Console.WriteLine("Такого дня недели не существует.");
        }

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
