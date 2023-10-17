// 4. Напишите программу для нахождения корней квадратного уравнения.


class Program
{
    static void Main()
    {
        // Объявляем переменные для коэффициентов квадратного уравнения
        double a, b, c;

        // Выводим сообщение, чтобы пользователь ввел коэффициент a
        Console.Write("Введите коэффициент a: ");

        // Считываем введенное пользователем значение и преобразуем его в число с плавающей точкой (double)
        a = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Введите коэффициент b: ");

        
        b = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Введите коэффициент c: ");

        
        c = Convert.ToDouble(Console.ReadLine());

        // Вычисляем дискриминант
        double discriminant = b * b - 4 * a * c;
        Console.WriteLine("Дискриминант: " + discriminant);

        // Проверяем значение дискриминанта
        if (discriminant > 0)
        {
            // Два действительных корня
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Уравнение имеет два корня:");
            Console.WriteLine("x1 = " + root1);
            Console.WriteLine("x2 = " + root2);
        }
        else if (discriminant == 0)
        {
            // Один действительный корень
            double root = -b / (2 * a);
            Console.WriteLine("Уравнение имеет один корень:");
            Console.WriteLine("x = " + root);
        }
        else if (discriminant < 0) 
            {
            Console.WriteLine("Дискриминант отрицательный, корней нет");
            }

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}

