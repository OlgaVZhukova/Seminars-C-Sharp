// Задайте двумерный массив. Найдите элементы, у которых 
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

//Примечание: четная позиция она будет четной для пользователя, для нас она будет нечетной, т.к. отсчет позиций начинается у нас с нуля.

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

int[,] EvenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) // % - это остаток от деления на 2 и это должно равняться 0, чтобы быть четным
            {
                array[i, j] *= array[i, j]; // *= это все равно что возвести в квадрат
            }
        }
    }
    return array;
}


// even - четный, odd - нечетный

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

//теперь нужно массив сгенерировать
int[,] array = CreateArray(3, 4);
PrintArray(array);
System.Console.WriteLine(); // запишем пустую строку для удобства отображения результата, отделить один массив от другого
PrintArray(EvenArray(array)); // функция вызывает функцию

