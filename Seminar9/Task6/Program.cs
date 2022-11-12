// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

bool Power(int num, int num1)
{
    if (num1 <= 1)
    {
        return true;
    }
    return (num % (num1) != 0) && Power(num, num1 - 1);
}

int num = Prompt("Введите число");
bool result = Power(num, num - 1);
System.Console.WriteLine(result);

