// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int m;
int n;

void Recursion(int value)
{
    Console.Write($"{value}");

    if (value == n)
    {
        return;
    }
    else
    {
        Console.Write(", ");
    }

    Recursion(value + 1);
}

Console.Write("Введите начало диапазона: ");
m = int.Parse(Console.ReadLine()!);

Console.Write("Введите конец диапазона: ");
n = int.Parse(Console.ReadLine()!);

if (m > n)
{
    Console.WriteLine("Конец диапазона должен быть больше начала диапазона, выходим... ");

    return;
}

Console.Write($"m = {m}; n = {n} -> \"");

Recursion(m);

Console.WriteLine("\"");
