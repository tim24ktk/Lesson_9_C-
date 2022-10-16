/*
    Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// метод получения числа от пользователя
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// метод вывода натуральных чисел от N до 1
int PrintNumbers(int n)
{

    if (n == 1)
    {
        return n;
    }

    Console.Write($"{n}, ");

    return PrintNumbers(n - 1);
}

int n = GetNumber("Введите значение N: ");
Console.Write(PrintNumbers(n));
Console.WriteLine();