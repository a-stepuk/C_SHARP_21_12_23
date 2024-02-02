// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool Palindrom(string word)
{
    int size = word.Length;

    for (int i = 0; i < size / 2; i++)
    {
        if (word[i] != word[size - 1 - i])
        {
            return false;
        }
    }

    return true;
}

Console.Write("Введите текст: ");

string text = Console.ReadLine()!;

bool result = Palindrom(text);

Console.WriteLine($"Введенный текст является палиндромом? - {result}");
