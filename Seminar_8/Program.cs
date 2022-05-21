/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
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
int[,] ShowArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
void SelectionSortArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                    (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
            }
        }
    }
}
int[,] myArray = CreateRandomArray2(3, 4);
Console.WriteLine();
SelectionSortArray2(myArray);
ShowArray2(myArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка

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
int rowWithMinSum(int[,] array)
{
    int sum = 0;
    int min = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += array[i, j];
                min += array[i, j];
            }
            else
            {
                sum += array[i, j];
            }
        }
        if (sum < min)
        {
            min = sum;
            row = i + 1;
        }
        sum = 0;
    }
    Console.WriteLine();
    return row;
}
int[,] myArray = CreateRandomArray2(4, 4);
Console.WriteLine(rowWithMinSum(myArray) + " строка");

*/

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

int[,] CreateSpiralArray(int n)
{
    int[,] array = new int[n, n];
    int firstNumber = 1;
    int count = 0;
    int i = 0;
    int j = 0;
    while (firstNumber < n * n + 1)
    {
        for (j = count; j < n - count; j++)
        {
            array[count, j] = firstNumber;
            firstNumber++;
        }
        for (i = count + 1; i < n - count; i++)
        {
            array[i, n - count - 1] = firstNumber;
            firstNumber++;
        }
        for (j = n - count - 2; j > count; j--)
        {
            array[n - count - 1, j] = firstNumber;
            firstNumber++;
        }
        for (i = n - count - 1; i > count; i--)
        {
            array[i, count] = firstNumber;
            firstNumber++;
        }
        count++;
    }
    return array;
}
int[,] ShowArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] myArray = CreateSpiralArray(4);
ShowArray2(myArray);