// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.).

string readFromConsole;
bool isNumber;
int arrayLength;

Console.Write("Введите длину массива: ");
readFromConsole = Console.ReadLine()!;

isNumber = int.TryParse(readFromConsole, out arrayLength);

if (!isNumber || arrayLength <= 0)
{
    Console.WriteLine("Введена неверная длина массива. Выходим...");

    return;
}

int[] array = CreateAndFillArray(arrayLength);

Console.WriteLine($"Исходный массив случайных чисел от 0 до 9 длиной {arrayLength} чисел:");
PrintArrayToConsole(array);

FlipOverArray(array);

Console.WriteLine($"Перевёрнутый массив:");
PrintArrayToConsole(array);

int[] CreateAndFillArray(int size)
{
    int[] result = new int[size];

    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        result[i] = random.Next(0, 10);
    }

    return result;
}

void FlipOverArray(int[] pArray)
{
    int tempElement;

    for (int i = 0, j = pArray.Length - 1; i < j; i++, j--)
    {
        tempElement = pArray[i];
        pArray[i] = pArray[j];
        pArray[j] = tempElement;
    }
}

void PrintArrayToConsole(int[] pArray)
{
    foreach (int element in pArray)
    {
        Console.Write($"{element} ");
    }

    Console.Write("\n\n");
}
