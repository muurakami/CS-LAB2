
class Program
{
    static void Main()
    {
        // Выводим сообщение, чтобы пользователь ввел сумму покупки
        Console.Write("Введите сумму покупки (рубли): ");

        // Считываем введенную пользователем сумму покупки и преобразуем ее в число с плавающей точкой (double)
        double purchaseAmount = Convert.ToDouble(Console.ReadLine());

        // Выводим сообщение, чтобы пользователь ввел рейтинг покупателя
        Console.Write("Введите рейтинг покупателя (0-5): ");

        // Считываем введенный пользователем рейтинг и преобразуем его в целое число (int)
        int customerRating = Convert.ToInt32(Console.ReadLine());

        // Устанавливаем начальное значение скидки
        double discount = 0;

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

        // Вычисляем сумму скидки на основе рейтинга покупателя
        double ratingDiscount = customerRating * 100;

        // Проверяем, чтобы сумма скидки от рейтинга не превышала 500 рублей
        ratingDiscount = Math.Min(ratingDiscount, 500);

        // Вычисляем сумму скидки
        double totalDiscount = Math.Max(discount, ratingDiscount); // Берем максимальную из двух скидок

        // Вычисляем итоговую сумму к оплате
        double totalAmount = purchaseAmount - totalDiscount;

        // Выводим результаты
        Console.WriteLine($"Размер бонусной скидки: {totalDiscount} руб.");
        Console.WriteLine($"Итоговая сумма к оплате: {totalAmount} руб.");

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}

