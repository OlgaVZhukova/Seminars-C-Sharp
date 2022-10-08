// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится 
// эта точка.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateCoords(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        Console.WriteLine("Точка находится как минимум на одной из осей");
        return false;
    }

    return true;
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }
    return 3;
}

int x = Prompt("Введите x >");
int y = Prompt("Введите y >");

if (!ValidateCoords(x, y))
{
    return;
}

System.Console.WriteLine($"{GetQuarter(x, y)} четверть");


