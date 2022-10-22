// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2

// Сумма элементов главной диагонали: 1+9+2 = 12

int Prompt()
{
    System.Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

// рандомное заполнение двумерного массива
int[,] RandomMatrixFill(int line, int column)
{
    int[,] matrix = new int [line, column];
    Random rnd = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, int line, int column)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            System.Console.Write($"{matrix[i, j]} ");;
        }
        System.Console.WriteLine(); // отображение простой строчки после каждой строчки
    }
    System.Console.WriteLine();
}

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[,] array = RandomMatrixFill(5, 5); // эта задача будет работать только с квадратами
PrintMatrix(array, 5, 5);
System.Console.WriteLine(SumDiagonal(array));
