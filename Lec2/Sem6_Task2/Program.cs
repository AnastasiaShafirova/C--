// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

char[] StringCharToArray(string s)
{
    char[] arrStr = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        arrStr[i] = s[i];
    }
    return arrStr;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        Console.Write($"{array[i]}, ");
        else
        Console.Write($"{array[i]}");
    }
}

Console.WriteLine("Введите строку");
string str = Console.ReadLine();

char[] resArray = StringCharToArray(str);
PrintArray(resArray);


