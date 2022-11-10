// Задача 3: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9.

int[,] CreateMatrix(int y, int x, int minLimit, int maxLimit)
{
	int[,] matrix = new int[y, x];
	Random rnd = new Random();
	for (int j = 0; j < matrix.GetLength(0); j++)
	{
		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			matrix[j, i] = rnd.Next(minLimit, maxLimit + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int j = 0; j < matrix.GetLength(0); j++)
	{
		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			System.Console.Write($"{matrix[j, i]} ");
		}
	System.Console.WriteLine();
	}
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write($"{array[i]} ");
	}
	System.Console.WriteLine();
}

int[] Dictionary(int[,] matrix)
{
	int[] dict = new int [10];
    for (int i = 0; i < dict.Length; i++)
    {
        int count = 0;
        foreach (var item in matrix)
        {
            if (item == i)
            {
                count++;
            }
            dict[i] = count;
        }
    }
	return dict;
}

int[] FrequeDict(int[,] matrix)
{
	int[] dict = new int [10];
	foreach (var item in matrix)
	{
		dict[item]++;
	}
	return dict;
}


int Prompt(string message)
{
	Console.Write(message);
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int y = Prompt("Узнаем размер матрицы. Введите количество строк > ");
int x = Prompt("Узнаем размер матрицы. Введите количество столбцов > ");
int min = Prompt("Заполняем матрицу. Введите минимальный предел > ");
int max = Prompt("Заполняем матрицу. Введите максимальный предел > ");
int[,] myMatrix = CreateMatrix(y, x, min, max);
Console.WriteLine("Ваша матрица > ");
PrintMatrix(myMatrix);
Console.WriteLine();
int [] dict = FrequeDict(myMatrix);
PrintArray(dict);
