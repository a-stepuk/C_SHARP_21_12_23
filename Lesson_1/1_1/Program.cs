﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");

int firstNumber = 50;
int secondNumber = 50;

if (firstNumber < secondNumber)
{
    Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "`");
}
else if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое число `" + firstNumber + "` больше чем второе число `" + secondNumber + "`");
}
else
{
    Console.WriteLine("Введенные числа равны `" + secondNumber + "`");
}
