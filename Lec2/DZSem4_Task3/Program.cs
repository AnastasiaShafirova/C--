// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] ReverseArray(int[] arr)
{
   int[] reverse = new int[arr.Length];
   
   for (int i = 0; i < arr.Length; i++)
{
    reverse[i] = arr[arr.Length - 1 - i];
}

return reverse;

}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
int[] reverse = ReverseArray(arr);
string reversedString = string.Join(", ", reverse);
Console.WriteLine($" => [{reversedString}]");
