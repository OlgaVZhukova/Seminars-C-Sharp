// Вывести последовательность чисел: одна 1, две 2, три 3, и т.д. до 10 - десять десяток.

int Prompt()
{
    System.Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int number = Prompt();

for (int i = 1; i <= number; i++)
{
    for (int j = 0; j < i; j++)
    {
        System.Console.Write($"{i}, ");
    }
}
