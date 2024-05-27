// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void PrintConsonants(string txt, int index = 0)
{
    if (index == txt.Length)
    {
        return;
    }
    string vowels = "aeiouy";
    if (!vowels.Contains(txt[index]))
            {
                Console.Write($"{txt[index]}");
            }

PrintConsonants(txt, index +1);
}

Console.WriteLine("Введите текст, содержащий латинские буквы: ");
string text = Console.ReadLine();
Console.WriteLine();
PrintConsonants(text);