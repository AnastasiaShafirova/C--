// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < arr.Length)
// {
//     arr[i] = i + 2;
//     // Console.Write(arr[i]);
//     // Console.Write(' ');
//     Console.Write($"{arr[i]} ");

//     i = i + 2;
// }

int n = 10;
int[] array = {2,5,4,7,8,35,1,3,8,5};
int i = 0;

while (i < n)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
