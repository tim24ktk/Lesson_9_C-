/*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/

// метод получения числа от пользователя
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


///Метод вычисления функции Аккермана:
int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }

    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}


int m = GetNumber("Введите значение M: ");
int n = GetNumber("Введите значение N: ");

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");
