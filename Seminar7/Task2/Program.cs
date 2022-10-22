// Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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

//теперь нужно массив сгенерировать
int[,] array = CreateArray(3, 4);
PrintArray(array);

