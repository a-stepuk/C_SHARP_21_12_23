// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int number = -4;

if (number <= 0)
{
    Console.WriteLine($"number = {number} => заданное число не является натуральным");

    return;
}

int digit = 0;
string str = "";

if (number < 10)
{
    Console.WriteLine($"number = {number} => {number}");
}
else
{
    while (number > 0)
    {
        digit = number % 10;
        number /= 10;

        str += digit;
    }

    for (int i = str.Length - 1; i >= 0; i--)
    {
        Console.Write(str[i]);

        if (i != 0)
        {
            Console.Write(", ");
        }
    }
}
