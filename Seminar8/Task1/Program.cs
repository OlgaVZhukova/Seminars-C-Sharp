// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] ChangeMatrix(int[,] matrix)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		int temp = matrix[0, j];
		matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
		matrix[matrix.GetLength(0) - 1, j] = temp;
	}
	return matrix;
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
ChangeMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
