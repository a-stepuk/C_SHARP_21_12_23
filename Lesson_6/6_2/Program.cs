// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string LowUp(string word)
{
    return word.ToLower();
}

Console.Write("Введите текст: ");

string text = Console.ReadLine()!;

string result = LowUp(text);

Console.WriteLine(result);
