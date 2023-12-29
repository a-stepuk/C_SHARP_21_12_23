// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int number = 54;

if (number <= 0)
{
    Console.WriteLine($"number = {number} => заданное число не является натуральным");

    return;
}
else if (number > 10000)
{
    Console.WriteLine($"number = {number} => заданное число слишком большое");

    return;
}

string num_digits = "";

int counter = 10000;
int digit = number / counter;

while (digit != 0)
{
    num_digits += digit + ", ";
    counter /= 10;
    digit = number / counter;
}

Console.WriteLine($"number = {number} => " + num_digits);
