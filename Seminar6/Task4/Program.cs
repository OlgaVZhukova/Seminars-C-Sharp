// : Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] RandomArrGen()
{
    int length = new Random().Next(1, 15);
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]");
    }
}

int Prompt()
{
    System.Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int count = Prompt();

int tmp1 = 0;
int tmp2 = 1;
while (count > 0)
{
    int tmp = tmp1 + tmp2;
    System.Console.WriteLine($"{tmp1}");
    tmp1 = tmp2;
    tmp2 = tmp;
    count--;
}

