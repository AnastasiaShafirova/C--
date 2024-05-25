// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == str[i])
            {
                count++;
            }
        }
    }
    return count;
}


Console.WriteLine("Введите слово");
string start = Console.ReadLine();
Console.WriteLine($"В слове {CountVowels(start)}  гласных");