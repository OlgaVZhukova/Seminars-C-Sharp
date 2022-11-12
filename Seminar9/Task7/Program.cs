// Степень двойки (не рекурсией)

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

bool IsBinary(int num)
{
    return ((num - 1) & num) == 0;
}

int num = Prompt("Введите число");
System.Console.WriteLine(IsBinary(num));

