// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int number = 50;

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"number = {number} => да");
}
else
{
    Console.WriteLine($"number = {number} => нет");
}
