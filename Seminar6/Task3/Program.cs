// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Prompt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[] Binary(int number)
{
    int[] array = new int[10];
    int count = array.Length - 1;
    while (number > 0)
    {
        array[count] = number % 2;
        number /= 2;
        count --;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int a = Prompt();
PrintArray(Binary(a));
