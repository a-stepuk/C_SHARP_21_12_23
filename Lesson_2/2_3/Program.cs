// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = 33;

if (number < 10 || number > 99)
{
    Console.WriteLine($"number = {number} => заданное число выходит за пределы интервала [10, 99]");

    return;
}

int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.WriteLine($"number = {number} => {a}");
}
else
{
    Console.WriteLine($"number = {number} => {b}");
}
