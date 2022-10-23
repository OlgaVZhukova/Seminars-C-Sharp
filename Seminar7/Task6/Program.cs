// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int Prompt()
{
    System.Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");;
        }
        System.Console.WriteLine(); // отображение простой строчки после каждой строчки
    }
    System.Console.WriteLine();
}

int SumOfMaxLine(int[,] matrix, int line, int column)
{
    int sum = 0;
    for (int i = 0; i < line; i++)
    {
        int max = -1;
        for (int j = 0; j < column; j++)
        {
            if (max < matrix[i, j])
            {
                max = matrix[i, j];
            }
        }
        sum += max;
    }
    System.Console.WriteLine($"Сумма максимальных по строкам элементов равна {sum}");
    return sum;
}

int SumOfMinColumn(int[,] matrix, int line, int column)
{
    int sum = 0;
    for (int i = 0; i < column; i++)
    {
        int min = matrix[0, i];
        for (int j = 0; j < line; j++)
        {
            if (min > matrix[j, i])
            {
                min = matrix[j, i];
            }
        }
        sum += min;
    }
    System.Console.WriteLine($"Сумма минимальных по строкам элементов равна {sum}");
    return sum;
}

int line = Prompt();
int column = Prompt();
int[,] matrix = RandomMatrixFill(line, column);
PrintMatrix(matrix);
System.Console.WriteLine(SumOfMaxLine(matrix, line, column) - SumOfMinColumn(matrix, line, column));

