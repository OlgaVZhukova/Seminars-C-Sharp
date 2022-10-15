// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length, int minLimit, int maxLimit)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
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

int[] myArray = CreateArray(10, 0, 10);
PrintArray(myArray);

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] secondArray;

if (myArray.Length % 2 == 0) // если четное
{
    secondArray = new int[myArray.Length / 2];
}
else
{
    secondArray = new int[myArray.Length / 2 + 1];
}

for (int i = 0; i < myArray.Length / 2; i++)
{
    secondArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
}

PrintArray(secondArray);
