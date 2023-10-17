
class Program
{
    static void Main()
    {
        // Создаем объект для генерации случайных чисел
        Random random = new();

        // Генерируем два случайных множителя от 1 до 9
        int multiplier1 = random.Next(1, 10);
        int multiplier2 = random.Next(1, 10);

        // Вычисляем правильный ответ
        int correctAnswer = multiplier1 * multiplier2;

        // Выводим задачу на экран
        Console.Write($"Сколько будет {multiplier1} * {multiplier2}? ");

        // Считываем ответ пользователя и преобразуем его в целое число (int)
        int userAnswer = Convert.ToInt32(Console.ReadLine());

        // Проверяем, верный ли ответ
        if (userAnswer == correctAnswer)
        {
            Console.WriteLine("Верно!");
        }
        else
        {
            Console.WriteLine($"Неверно. Правильный ответ: {correctAnswer}");
        }

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
