/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomArray2(int size0, int size1)
{
    double[,] array = new double[size0, size1];
    for (int i = 0; i < size0; i++)
    {
        for (int j = 0; j < size1; j++)
        {
            array[i, j] = new Random().NextDouble() * 19.9 - 9.9;
            Console.Write("{0,5:f1}", array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
}
CreateRandomArray2(3, 4);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateRandomArray2(int size0, int size1)
{
    int[,] array = new int[size0, size1];
    for (int i = 0; i < size0; i++)
    {
        for (int j = 0; j < size1; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

string FindOfElements(int[,] array)
{
    Console.Write("Input element m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input element n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m && j == n)
                return Convert.ToString($"[{i}; {j}] -> {array[i, j]}");
        }
    }
    return "No elements!";
}

int[,] myArray = CreateRandomArray2(3, 4);
Console.WriteLine(FindOfElements(myArray));

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomArray2(int size0, int size1)
{
    int[,] array = new int[size0, size1];
    for (int i = 0; i < size0; i++)
    {
        for (int j = 0; j < size1; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write("{0,6}", array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void ArithmeticMeanСolumn(int[,] array)
{

    double[] arr = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arr[i] += array[j, i];
        }
        Console.Write("{0,6}", arr[i] / array.GetLength(0));
    }
}

int[,] myArray = CreateRandomArray2(4, 4);
Console.WriteLine();
ArithmeticMeanСolumn(myArray);