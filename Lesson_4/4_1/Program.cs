// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

string readFromConsole;
bool isNumber;
int numericValue;

while (true)
{
    Console.Write("Введите любое целое число: ");
    readFromConsole = Console.ReadLine()!;

    if (readFromConsole.Equals("q"))
    {
        Console.WriteLine("Введен символ 'q'. STOP");

        return;
    }

    isNumber = int.TryParse(readFromConsole, out numericValue);

    if (isNumber && numericValue < 0)
    {
        numericValue = -numericValue;
    }

    if (!isNumber || numericValue == 0)
    {
        Console.WriteLine("Введено не число либо ноль. Повторите ввод.");

        continue;
    }

    if (IsEvenNumber(SumNumberDigits(numericValue)))
    {
        Console.WriteLine("Введено число c чётной суммой цирф. STOP");

        return;
    }
}

bool IsEvenNumber(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int SumNumberDigits(int number)
{
    string numberAsString = number + "";
    int result = 0;

    while (number > 0)
    {
        result = number % 10 + result;
        number /= 10;
    }

    return result;
}
