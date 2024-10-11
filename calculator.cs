double a;
double b;
double total;
char oper;

while (true) // Бесконечный цикл, чтобы программа продолжалась
{
    try
    {
        Console.WriteLine("Введите первое число:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор (+, -, *, /):");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());

        if (oper == '+')
        {
            total = a + b;
            Console.WriteLine("Сумма " + a + " и " + b + " равна " + total + ".");
        }
        else if (oper == '-')
        {
            total = a - b;
            Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
        }
        else if (oper == '*')
        {
            total = a * b;
            Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
        }
        else if (oper == '/')
        {
            if (b == 0) // Проверка деления на ноль
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
            }
            else
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            }
        }
        else
        {
            Console.WriteLine("Неизвестный оператор.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка: пожалуйста, введите правильное число.");
    }
    catch (Exception ex) // Общая обработка исключений
    {
        Console.WriteLine("Произошла ошибка: " + ex.Message);
    }

    Console.WriteLine("Хотите продолжить? (y/n):");
    char continueInput = Convert.ToChar(Console.ReadLine());
    if (continueInput != 'y' && continueInput != 'Y')
    {
        break; // Выход из цикла
    }
}
