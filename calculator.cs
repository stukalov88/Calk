double a;
double b;
double total;
char oper;

/* простой калькулятор (+ - * \) */

Console.WriteLine("Введите первое число:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Выберите действие (+,-,*,/):");
oper = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Введите второе число:");
b = Convert.ToDouble(Console.ReadLine());

if (oper == '+')
{
    total = a + b;
    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
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
    total = a / b;
    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
}
else
{
    Console.WriteLine("Неизвестный оператор.");
}