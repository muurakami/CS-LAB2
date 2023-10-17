// Вариант 2. Задание 4. Напишите программу для начисления бонусной скидки на товар, которая зависит от суммы приобретенного товара. Если сумма не более 1000 руб. – скидка 1%, если не более 5000 руб. – 5 %, если больше 5000 руб. – 10%. Пользователь вводит сумму покупки, программа выводит на экран размер бонусной скидки и итоговую сумму к оплате. 


class Program
{
    static void Main()
    {
        // Выводим сообщение, чтобы пользователь ввел сумму покупки
        Console.Write("Введите сумму покупки (рубли): ");

        // Считываем введенную пользователем сумму покупки и преобразуем ее в число с плавающей точкой (double)
        double purchaseAmount = Convert.ToDouble(Console.ReadLine());

        double discount;

        // Проверяем сумму покупки и начисляем скидку в зависимости от условий
        if (purchaseAmount <= 100)
        {
            discount = 0.01; // 1% скидка
        }
        else if (purchaseAmount <= 300)
        {
            discount = 0.03; // 3% скидка
        }
        else
        {
            discount = 0.05; // 5% скидка
        }

        // Вычисляем сумму скидки
        double discountAmount = purchaseAmount * discount;

        // Вычисляем итоговую сумму к оплате
        double totalAmount = purchaseAmount - discountAmount;

        // Выводим результаты
        Console.WriteLine($"Размер бонусной скидки: {discountAmount} руб.");
        Console.WriteLine($"Итоговая сумма к оплате: {totalAmount} руб.");

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
