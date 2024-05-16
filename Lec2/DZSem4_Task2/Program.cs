// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArrayRndInt(int size, int min, int max) //передаем размер массива
{
    int[] array = new int[size];
    Random rnd = new Random(); //подключаем рандом к нашей функции

    for (int i = 0; i < size; i++) //либо array.Length
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
    
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }

        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}

static int CountNumbersEven(int[] arr)
{
int count = 0;
   foreach (int num in arr)
    {
        if(num % 2 == 0) 
        {
            count++;     
        }
    }
    return count; 
}



int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);
int countEven = CountNumbersEven(arr);

// int countPrime = CountNumbers(arr);
Console.Write($" => {countEven}");