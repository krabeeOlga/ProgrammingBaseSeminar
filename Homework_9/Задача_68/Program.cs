﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAckermannFunction (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0)
    {
        return GetAckermannFunction (m - 1, 1);
    }
    return GetAckermannFunction(m - 1, GetAckermannFunction(m, n - 1));
}

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = GetAckermannFunction(m, n);
Console.WriteLine($"А({m},{n}) = {result}");