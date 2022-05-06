/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
//вторую цифру этого числа.

void SecondNumber(int n)
{
    Console.WriteLine(n / 10 % 10);
}
Console.Write("Input three-digit integer number = ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine("Incorrect number");
}
else
{
    SecondNumber(num);
}

*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

void ThirdNumber(int n)
{
    if (n < 100)
    {
        Console.WriteLine("No third number");
    }
    else
    {
        while (n > 999)
        {
            n = n / 10;
        }
        Console.WriteLine(n % 10);
    }
}
Console.Write("Input integer number = ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

void DayWeek(int n)
{
    if (n > 7 || n < 1)
    {
        Console.WriteLine("Incorrect number");
    }
    else
    {
        if (n >= 6)
        {
            Console.WriteLine("it's a day off");
        }
        else
        {
            Console.WriteLine("It's not a day off");
        }
    }
}
Console.Write("Input integer number = ");
int num = Convert.ToInt32(Console.ReadLine());
DayWeek(num);
*/