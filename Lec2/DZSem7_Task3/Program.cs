// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


void PrintArray(int[] arr, int i = 0)
{
    if (i < arr.Length)
    {
        PrintArray(arr, i + 1);
        Console.WriteLine(arr[i]);
    }
}

int[] arr = { 1, 2, 5, 0, 10, 34 };
PrintArray(arr);
