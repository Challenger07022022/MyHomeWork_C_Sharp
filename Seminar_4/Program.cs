/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void FindOfElements(int[] array)
{
    int evenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evenNumbers++;
    }
    Console.WriteLine("quantity of even numbers is " + evenNumbers);
}
int[] myArray = CreateRandomArray(4);
ShowArray(myArray);
FindOfElements(myArray);



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void FindOfElements(int[] array)
{
    int Numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            Numbers += array[i];
    }
    Console.WriteLine("sum of the numbers in odd positions is " + Numbers);
}
int[] myArray = CreateRandomArray(4);
ShowArray(myArray);
FindOfElements(myArray);

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void FindOfElements(double[] array)
{
    double minNumbers = array[0];
    double maxNumbers = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumbers)
            maxNumbers = array[i];
        else
        {
            if (array[i] < minNumbers)
                minNumbers = array[i];
        }
    }
    Console.WriteLine("The difference between the maximum and "
                    + "minimum element of the array is " + (maxNumbers - minNumbers));
}
double[] myArray = CreateArray(5);
ShowArray(myArray);
FindOfElements(myArray);
