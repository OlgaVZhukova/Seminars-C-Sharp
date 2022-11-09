// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

bool ValidateMatrix(int[,] matrix)
{
	if (matrix.GetLength(0) == matrix.GetLength(1))
	{
		return true;
	}
	return false;
}

int[,] TransponateMatrix(int[,] matrix)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		for (int i = j; i < matrix.GetLength(0); i++)
		{
			int temp = matrix[i, j];
			matrix[i, j] = matrix[j, i];
			matrix[j, i] = temp;
		}
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
Console.WriteLine();

if (ValidateMatrix(myMatrix))
{
	TransponateMatrix (myMatrix);
PrintMatrix(myMatrix);
}

else
{
	Console.WriteLine("Матрица не квадратная.");
}

