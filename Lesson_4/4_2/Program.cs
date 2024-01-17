// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

string readFromConsole;
bool isNumber;
int arrayLength;

Console.Write("Введите длину массива: ");
readFromConsole = Console.ReadLine()!;

isNumber = int.TryParse(readFromConsole, out arrayLength);

if (!isNumber || arrayLength <= 0)
{
    Console.WriteLine("Введено либо не число, либо число меньше ноля. Выходим...");

    return;
}

int[] array = CreateAndFillArray(arrayLength);

Console.Write("\n");
Console.Write($"Количество чётных чисел в нашем массиве: {SumEventNumbers(array)}");

int[] CreateAndFillArray(int size)
{
    int[] result = new int[size];

    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        result[i] = random.Next(100, 1000);
    }

    return result;
}

int SumEventNumbers(int[] pArray)
{
    Console.WriteLine($"Наш массив из {pArray.Length} чисел:");

    int counter = 0;

    foreach (int element in pArray)
    {
        if (element % 2 == 0)
        {
            counter++;
        }

        Console.Write($"{element} ");
    }

    Console.Write("\n\n");

    return counter;
}
