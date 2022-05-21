/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumIntegerElements(int m, int n)
{
    if (m == n)
        return n;
    else
        return m + SumIntegerElements(m + 1, n);
}
Console.Write("Input integer number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {m}; N = {n} -> {SumIntegerElements(m, n)}");

*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfDigitsOfNumber(int n)
{
    if (n == 0)
        return n;
    else
        return n % 10 + SumOfDigitsOfNumber(n / 10);
}
Console.Write("Input integer number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} -> {SumOfDigitsOfNumber(n)}");