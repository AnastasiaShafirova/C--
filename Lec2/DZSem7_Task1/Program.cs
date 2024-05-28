// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

string PrintNumbers(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + " " + PrintNumbers(m + 1, n);
}

void PrintNumbersTo(int m, int n)
    {
        if (m > n) return;
        Console.Write(m + " ", n);
        PrintNumbersTo(m + 1, n);
    }

Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {m} до {n}:");
Console.WriteLine(PrintNumbers(m, n));
PrintNumbersTo(m, n);