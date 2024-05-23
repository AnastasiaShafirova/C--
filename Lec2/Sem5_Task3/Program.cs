// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

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


void PrintArray(double[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]:F2}, ");
        }
        else
        {
            Console.Write($"{array[i]:F2}");
        }
        
    }
}

double[] GetAverageArrayRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = (double)sum / matrix.GetLength(1);
    }
    return array;
}
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

double[] resalt = GetAverageArrayRows(array2d);
PrintArray(resalt);
