// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.WriteLine(num);
}
else
{
    while (num > 0)
    {
        int currentDigit = num % 10;
        num /= 10;
        if (num > 0)
        {
            Console.WriteLine(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}

