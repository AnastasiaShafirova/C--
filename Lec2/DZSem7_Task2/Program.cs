// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Func(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (m > 0 && n == 0)
    {
        return Func(m - 1, 1);
    }
    else
        return Func(m - 1, Func(m, n - 1));
}
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({n}, {m}) = {Func(n, m)}");
