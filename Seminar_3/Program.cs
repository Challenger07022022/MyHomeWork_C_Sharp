/*
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Palindrome(int n)
{
    if (n > 9999 && n < 100000)
    {
        Console.Write(n + " -> ");
        if (((n / 10000) == (n % 10)) && ((n / 1000 % 10) == (n / 10 % 10)))
        {
            Console.Write("да");
        }
        else
            Console.Write("нет");
    }
    else
        Console.WriteLine("Incorrect number");
}
Console.Write("Input a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//в 3D пространстве.
//A (3,6,8); B (2,1,-7) -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceBetweenDot(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
}
Console.Write("input coordinate xA: ");
double x1Dot = Convert.ToDouble(Console.ReadLine());
Console.Write("input coordinate yA: ");
double y1Dot = Convert.ToDouble(Console.ReadLine());
Console.Write("input coordinate zA: ");
double z1Dot = Convert.ToDouble(Console.ReadLine());
Console.Write("input coordinate xB: ");
double x2Dot = Convert.ToDouble(Console.ReadLine());
Console.Write("input coordinate yB: ");
double y2Dot = Convert.ToDouble(Console.ReadLine());
Console.Write("input coordinate zB: ");
double z2Dot = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(DistanceBetweenDot(x1Dot, y1Dot, z1Dot, x2Dot, y2Dot, z2Dot));

*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void TableCubes(int n)
{
    int result = 1;
    Console.Write(n + " -> ");
    while (result <= n)
    {
        Console.Write(result * result * result + " ");
        result++;
    }
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 0)
    Console.WriteLine("Incorect number");
else
    TableCubes(num);