// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

// пишем рекурсивную функцию, которая будет считать чила в промежутке от 1 до N

void PrintNumbers(int number)
{
    if (number <= 0)
    {
        return;
    }

    PrintNumbers(number - 1);
    System.Console.Write(number + " ");
}

int num = Prompt("Введите число");
PrintNumbers(num);
