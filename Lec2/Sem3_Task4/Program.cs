// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 

// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]


int num;
Console.Write("Введите натуральное трехзначное число:  ");

num = Convert.ToInt32(Console.ReadLine());

int numCopy = num;
int count = 0;

// считает количество цифр в числе
while (numCopy != 0)
{
    numCopy /= 10;
    count++;
}
// создаем массив на колличество цифр
int[] array = new int[count];
int index = 0; // индекс последнего элемента

while (num != 0)
{
    array[index] = num % 10;
    num /= 10;
    index++;
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
       Console.Write(array[i] + " "); 
}
Console.Write("]");

