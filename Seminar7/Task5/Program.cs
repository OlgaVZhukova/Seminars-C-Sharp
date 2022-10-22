// Задайте двумерный массив. Введите элемент, и найдите 
// первое его вхождение, выведите позиции по горизонтали и 
// вертикали, или напишите, что такого элемента нет.

// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4].
// Введенный элемент 6, результат: такого элемента нет.

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

(int, int) Search(int[,] array, int number) // с помощью (int, int) можеи возвращать сразу два значения
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (i, j);
            }
        }
    }
    return (-1, -1);
}

int[,] array = RandomMatrixFill(4, 5);
PrintMatrix(array);
int number = Prompt();
(int line, int column) = Search(array, number);
if (line == -1)
{
    System.Console.WriteLine("Такого элемента нет");
}
else
{
    System.Console.WriteLine($"результат: [{line}, {column}]");
}

