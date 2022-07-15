// ДОМАШНЯЯ работа
// 1. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// int SumOf(int m, int n)
// {
//     if (m == n)
//         return m;
//     else
//         return m + SumOf(m + 1, n);
// }

// Console.Clear();
// Console.Write("Enter number of M: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of N: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Summa of M to N: {SumOf(min, max)}");


// 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
decimal AckNum(decimal m, decimal n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckNum(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckNum(m - 1, AckNum(m, n - 1));
    }
    else
        return n + 1;
}
Console.Clear();

Console.Write("Enter number of M: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of N: ");
int max = Convert.ToInt32(Console.ReadLine());
decimal res = AckNum(min, max);
Console.Write($"Function Ackermann of M to N: {res}");