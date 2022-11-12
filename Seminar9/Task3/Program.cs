// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int num)
{
    if (num <= 0)
    {
        return 0;
    }

    return num % 10 + PrintNumbers(num / 10);
}

int num = Prompt("Введите число");
int sum = 0;
sum = PrintNumbers(num);
System.Console.WriteLine(sum);