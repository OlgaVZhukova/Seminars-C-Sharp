// Дана матрица, найти минимальное число.




int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5, 6);
        }
    }
    return array;
}

//выведем теперь это на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t"); //благодаря \t (табуляции) будут более-менее ровные колонки, даже с 2-х-значными числами
        }
        System.Console.WriteLine(); // отображение простой строчки после каждой строчки
    }
}

//функция поиска минимального числа
int Min(int[,] array)
{
    int min = array[0, 0];
    foreach (int item in array) // foreach - перебирает все элементы последовательно
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}


//теперь нужно массив сгенерировать
int[,] array = CreateArray(3, 4);
PrintArray(array);
int min = Min(array);
System.Console.WriteLine($"Минимальный эелемент равен {min}");
