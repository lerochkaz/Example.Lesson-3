// // Задача 1
Console.Clear();
int number = new Random().Next(100, 1000);
int a = number / 100;
int c = number % 100 % 10;
Console.Write($"{a}{c}");

// // Задача 2
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

if (b % a == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    int c = b % a;
    Console.WriteLine(c);
}

// // Задача 3
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine("Число делиться на 7 и на 23");
}
else
{
    Console.WriteLine("Число не делиться на 7 и на 23");
}

// // Задача 4
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a * a == b)
{
    Console.WriteLine("Да, является квадратом первого числа");
    Console.WriteLine(b);
}
else
{
    if (b * b == a)
    {
        Console.WriteLine("Да, является квадратом второго числа");
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("Нет, не является");

    }
}
