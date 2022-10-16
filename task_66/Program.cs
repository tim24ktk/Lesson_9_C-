/*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

// метод получения числа от пользователя
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// метод суммы натуральных элементов в промежутке от M до N
void GetSumm(int m, int n, int summ)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {summ}");
        return;
    }

    summ += m++;

    GetSumm(m, n, summ);
}


int m = GetNumber("Введите значение M: ");
int n = GetNumber("Введите значение N: ");

GetSumm(m, n, 0);