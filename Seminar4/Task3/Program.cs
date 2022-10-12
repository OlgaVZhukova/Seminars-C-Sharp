// Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = InputNumber("Введите число: ");

int multiply = 1;
for (int i = 1; i <= number; i++)
{
    multiply = multiply * i;
}


System.Console.WriteLine($"Выводим факториал: {multiply}");




