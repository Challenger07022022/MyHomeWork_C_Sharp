/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
int moreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int[] myArray = CreateArray(5);
ShowArray(myArray);
Console.Write($"-> {moreZero(myArray)}");



// Задача 42: Напишите программу, которая будет преобразовывать десятичное
// число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Вариант 1:
int LengthBinary(int num10)
{
    int length = 0;
    while (num10 > 0)
    {
        num10 = num10 / 2;
        length++;
    }
    return length;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
}
void Convert10to2(int n)
{
    int convert2 = 0;
    int[] array = new int[LengthBinary(n)];
    for (int i = 0; n >= 1; i++)
    {
        convert2 = n % 2;
        array[array.Length - 1 - i] = convert2;
        n /= 2;
    }
    ShowArray(array);
}

Console.Write("Input in decimal number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("A number in binary notation is equal to = ");
Convert10to2(num);

// Вариант 2:
Console.Write("Input in decimal number: ");
int num = Convert.ToInt32(Console.ReadLine());
string binary = string.Empty;
while (num > 0)
{
    binary = (num % 2) + binary;
    num /= 2;
}
Console.Write($"A number in binary notation is equal to = {binary}");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1,
// b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void Intersection2Straight(double b1, double k1, double b2, double k2)
{
    double x;
    double y;
    x = (b1 - b2) / (k2 - k1);
    y = k2 * x + b2;
    if ((k2 - k1) == 0) Console.WriteLine("The lines are parallel!");
    else Console.WriteLine($"The intersection point of two straight lines is equal to: ({x}; {y})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Intersection2Straight(b1, k1, b2, k2);
