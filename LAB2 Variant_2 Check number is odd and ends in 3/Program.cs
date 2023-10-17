/* Вариант 2.
 2.	Проверить, является ли введенное с клавиатуры число нечетным и оканчивающимся на 3.
*/


class Program
{
    static void Main()
    {
        // Выводим сообщение, чтобы пользователь ввел число
        Console.Write("Введите целое число: ");

        // Считываем введенное пользователем число и преобразуем его в целое число (int)
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, является ли число нечетным и оканчивается ли оно на 3
        bool isOddAndEndsWith3 = (number % 2 != 0) && (number % 10 == 3);

        // Выводим результат проверки
        if (isOddAndEndsWith3)
        {
            Console.WriteLine($"{number} является нечетным и оканчивается на 3.");
        }
        else
        {
            Console.WriteLine($"{number} не удовлетворяет условию.");
        }

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
