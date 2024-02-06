// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// Зададим явно массив целых чисел:
int[] numbers = { 1, 2, 5, 0, 10, 34 };

void Recursion(int index)
{
    Console.Write($"{numbers[index]}");

    if (index == 0)
    {
        return;
    }
    else
    {
        Console.Write(" ");
    }

    Recursion(index - 1);
}

Console.Write("[ ");

int numbersLength = numbers.Length;

for (int i = 0; i < numbersLength; i++)
{
    Console.Write($"{numbers[i]}");

    if (i < numbersLength - 1)
    {
        Console.Write(", ");
    }
}

Console.Write(" ] => ");

Recursion(numbersLength - 1);
