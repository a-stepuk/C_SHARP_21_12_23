// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int x = 4;
int y = -2;

if (x == 0 && y == 0)
{
    Console.WriteLine($"{x}, {y} => центр координат");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine($"{x}, {y} => 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine($"{x}, {y} => 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine($"{x}, {y} => 3");
}
else
{
    Console.WriteLine($"{x}, {y} => 4");
}
