// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return Akker(m - 1, Akker(m, n - 1));
    }
}

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0)
{
    Console.WriteLine("Оба числа должны быть неотрицательными, выходим... ");

    return;
}

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Akker(m, n)}");
