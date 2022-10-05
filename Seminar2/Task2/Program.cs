// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);
int result1 = number / 10;
int result2 = number % 10;
if (result1 < result2)
{
    System.Console.WriteLine($"Вторая цифра {result2} больше первой {result1}");
}
else
{
    System.Console.WriteLine($"Первая цифра {result1} больше второй {result2}");
}
if (result1 == result2) { System.Console.WriteLine("Цифры равны между собой"); }

// непонятно, если цифры равны, как лучше сделать
