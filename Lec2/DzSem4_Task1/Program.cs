// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



void EvenCaculator()
{
       while (true)
       {
           Console.WriteLine("Введите целое число или 'q' для выхода:");
           string? input = Console.ReadLine();
           // Проверяем, был ли введен символ 'q' для выхода
           
           if (input?.ToLower() == "q")
           {
               Console.WriteLine("Программа завершена.");
               break;
           }
           // Пытаемся преобразовать введенную строку в число
           if (int.TryParse(input, out int number))
           {
               // Проверяем, четная ли сумма цифр числа
               if (IsSumOfDigitsEven(number))
               {
                   Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                   break;
               }
               else
               {
                   Console.WriteLine($"Сумма цифр числа {number} нечетная.");
               }
           }
           else
           {
               Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода.");
           }
       }
   

   // Метод для проверки четности суммы цифр числа
   bool IsSumOfDigitsEven(int number)
   {
       int sum = 0;
       while (number != 0)
       {
           sum += number % 10;
           number /= 10;
       }
       return sum % 2 == 0;
   }
}
EvenCaculator();