// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string ChArrToStr(char[,] arr)
{
    string result = "";

    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result += arr[i, j];
        }
    }

    return result;
}

char[,] charArray = new char[,] {
    { 'N', 'i', 'c', 'e' },
    { 'W', 'e', 'a', 't' }
};

string res = ChArrToStr(charArray);

Console.WriteLine(res);
