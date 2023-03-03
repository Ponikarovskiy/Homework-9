﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 68. Напиcать программу вычисления функции Аккермана с помощью рекурсии*");
System.Console.WriteLine();
System.Console.WriteLine("Введите число m");
if (!int.TryParse(Console.ReadLine(), out int m) || m < 0)
{
    System.Console.WriteLine("Ошибка ввода!");
    return;
}

System.Console.WriteLine("Введите число n");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
    System.Console.WriteLine("Ошибка ввода!");
    return;
}

double Akkerman(double a, double b)
{
    if (a == 0) return b + 1;
    else
    {
        if (a != 0 && b == 0) return Akkerman(a - 1, 1);
        else
        {
            return Akkerman(a - 1, Akkerman(a, b - 1));
        }
    }

}
double result = Akkerman(m, n);
System.Console.WriteLine($"Функция Аккермана для чисел {m} и {n} принимает значение {result}");

