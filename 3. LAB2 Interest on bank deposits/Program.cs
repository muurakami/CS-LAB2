// 3. Напишите программу для начисления процента по вкладу в банке (процент зависит от суммы вклада).  На вход будет подаваться число (сумма вклада в тыс.руб.). При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами. 



class Program
{
    static void Main()
    {
        // Объявляем переменную для хранения суммы вклада
        double depositAmount;

        // Выводим сообщение, чтобы пользователь ввел сумму вклада
        Console.Write("Введите сумму вклада (в тыс. руб.): ");

        // Считываем введенную пользователем сумму вклада и преобразуем ее в число с плавающей точкой (double)
        depositAmount = Convert.ToDouble(Console.ReadLine());

        // Объявляем переменную для хранения процента начисления
        double interestRate;

        // Проверяем сумму вклада и устанавливаем процент начисления в зависимости от диапазона
        if (depositAmount < 100)
        {
            interestRate = 0.05; // 5%
        }
        else if (depositAmount >= 100 && depositAmount <= 200)
        {
            interestRate = 0.07; // 7%
        }
        else
        {
            interestRate = 0.10; // 10%
        }

        // Вычисляем сумму начисленных процентов
        double interestAmount = depositAmount * interestRate;

        // Вычисляем общую сумму с процентами
        double totalAmount = depositAmount + interestAmount;

        // Выводим результат на экран
        Console.WriteLine("Начисленные проценты: " + interestAmount + " тыс. руб.");
        Console.WriteLine("Общая сумма с процентами: " + totalAmount + " тыс. руб.");

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}


/*

class Program
{
    static void Main()
    {
        // Объявляем переменные для хранения суммы вклада, количества лет и процентной ставки
        double depositAmount;
        int years;
        double interestRate;

        // Выводим сообщение, чтобы пользователь ввел сумму вклада
        Console.Write("Введите сумму вклада (в тыс. руб.): ");

        // Считываем введенную пользователем сумму вклада и преобразуем ее в число с плавающей точкой (double)
        depositAmount = Convert.ToDouble(Console.ReadLine());

        // Выводим сообщение, чтобы пользователь ввел количество лет
        Console.Write("Введите количество лет: ");

        // Считываем введенное пользователем количество лет и преобразуем его в целое число (int)
        years = Convert.ToInt32(Console.ReadLine());

        // Выводим сообщение, чтобы пользователь ввел процентную ставку
        Console.Write("Введите процентную ставку (%): ");

        // Считываем введенную пользователем процентную ставку и преобразуем ее в десятичное число (например, 7% -> 0.07)
        interestRate = Convert.ToDouble(Console.ReadLine()) / 100.0;

        // Вычисляем сумму начисленных процентов за указанное количество лет
        double interestAmount = depositAmount * interestRate * years;

        // Вычисляем общую сумму с процентами
        double totalAmount = depositAmount + interestAmount;

        // Выводим результат на экран
        Console.WriteLine("Начисленные проценты за " + years + " лет: " + interestAmount + " тыс. руб.");
        Console.WriteLine("Общая сумма с процентами: " + totalAmount + " тыс. руб.");

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}

*/
