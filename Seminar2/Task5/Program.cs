// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8
// 1213 -> 3
// 845 -> 8


int a = new Random().Next(10, 10000);
System.Console.WriteLine(a);
int max = a % 10;
while (a > 0)
{
    int temp = a % 10;
    if (temp > max)
    {
        max = temp;
    }
    a = a / 10;
}

System.Console.WriteLine($"Максимальная цифра - {max}");
