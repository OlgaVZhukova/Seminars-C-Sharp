// Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputNumber(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    return int.Parse(str); // return Convert.ToInt32(str);
}

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

bool ValidateNumber(int number)
{
    if (number < 1)
    {
        System.Console.WriteLine("Число меньше единицы, сумма не считается");
        return false;
    }
    return true;
}

int n = InputNumber("Введите число > ");
if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");
}
