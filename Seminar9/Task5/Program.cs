// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

bool Power(int num)
{
    if (num <= 2)
    {
        return true;
    }
    return (num % 2 == 0) && (Power(num / 2));
}

int num = Prompt("Введите число");
bool result = Power(num);
System.Console.WriteLine(result);
