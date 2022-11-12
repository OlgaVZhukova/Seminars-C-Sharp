// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }

    System.Console.Write(m + " ");
    PrintNumbers(m + 1, n);
}

int m = Prompt("Введите число M");
int n = Prompt("Введите число N");
PrintNumbers(m, n);
