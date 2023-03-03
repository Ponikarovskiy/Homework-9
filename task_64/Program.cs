// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 64. Вывести натуральные числа в промежутке от N до 1*");
System.Console.WriteLine();
System.Console.WriteLine("Введите число n");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    System.Console.WriteLine("Ошибка ввода");
    return;
}

void PrintNumber(int n)
{
    if (n == 1) Console.Write($"{n} ");
    else
    {
        System.Console.Write($"{n} ");
        PrintNumber(n - 1);
    }
}

PrintNumber(n);
System.Console.WriteLine();