/*
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Exponentiation(int a, int b)
{
    int composition = a;
    for (int i = 1; i < b; i++)
    {
        composition *= a;
    }
    Console.WriteLine($"{a}, {b} -> {composition}");
}
Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Exponentiation(a, b);



// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumOfDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n = n / 10;
    }
    Console.WriteLine("The sum of the digits in a given number is equal to " + sum);
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
SumOfDigits(n);

*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(8);
ShowArray(myArray);
