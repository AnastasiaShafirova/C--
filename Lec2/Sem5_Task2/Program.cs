// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) //передаем размер массива
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random(); //подключаем рандом к нашей функции

    for (int i = 0; i < matrix.GetLength(0); i++) //либо array.Length
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int minSize = matrix.GetLength(0);
    if (minSize > matrix.GetLength(1))
    {
        minSize = matrix.GetLength(1);
    }

    for (int i = 0; i < minSize; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

int resalt = SumMainDiagonal(array2d);
Console.WriteLine(resalt);

