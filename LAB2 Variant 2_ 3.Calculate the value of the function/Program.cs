// Вариант 2. Задание 3 Вычислить значение функции y=f(x)
using System.Globalization; // Подключаем пространство имен System.Globalization для настройки формата чисел

class Program
{
    static void Main()
    {
        // Установим формат чисел с плавающей точкой, чтобы использовать точку вместо запятой
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        // Выводим сообщение, чтобы пользователь ввел значение x
        Console.Write("Введите значение x: ");

        // Считываем введенное пользователем значение и преобразуем его в число с плавающей точкой (double)
        double x = Convert.ToDouble(Console.ReadLine());

        // Вычисляем значение функции f(x) в зависимости от условий
        double result;

        if (x > 0)
        {
            result = 2 * Math.Sin(x);
        }
        else
        {
            result = 6 - x;
        }

        // Выводим результат
        Console.WriteLine($"Значение функции f({x}) = {result}");

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
