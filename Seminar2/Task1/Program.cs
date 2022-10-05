// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 99 & num1 < 1000)
{
    int result = num1 % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}

