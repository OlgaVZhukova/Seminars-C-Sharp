// // Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

//ищем минимальные индексы, чтобы знать, какой элемент удалять
(int, int) FindMin(int[,] matrix)
{
	int indexRow = 0;
int indexColumn = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if(matrix[i, j] < matrix[indexRow, indexColumn])
			{
				indexRow = i;
				indexColumn = j;
			}
		}
	}
	return (indexRow, indexColumn);
}

// пишем функцию, которая выдаст нам измененную матрицу
int[,] ChangeMatrix(int[,] matrix)
{
	int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
	(int minRow, int minColumn) = FindMin(matrix);
	int a = 0;
	int b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
	{
		if (i != minRow)
		{
			b = 0;
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if(i == minRow || j == minColumn)
				{
					
				}
				else
				{
					result[a, b] = matrix[i, j];
					b++;
				}
			}
			a++;
		}
	}
	return result;
}

//теперь нужно все это вызвать
int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(ChangeMatrix(matrix));
