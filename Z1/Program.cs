// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void Number (int number)
{
    if (number < 0) Console.Write($"{number} не является натуральнЫМ числом");
    if (number == 0) return;
    Console.Write($"{number} ");
    Number (number - 1);
}

Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Number(number);