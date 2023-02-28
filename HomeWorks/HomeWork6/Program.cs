//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int SumPositiveNum(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"введите {i+1} число:  ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num> 0) count ++;
    }
    return count;
}


Console.WriteLine("введите колличество чисел:  ");
int M = Convert.ToInt32(Console.ReadLine());

int result= SumPositiveNum(M);
Console.WriteLine($"колличество чисел больше нуля :{result} шт ");

*/

//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*


Console.WriteLine("Две прямые вида y = k1 * x + b1: ");

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

bool Зarallelism(double k1, double b1, double k2, double b2)
{
    return (k1 == k2 & b1 != b2);
}

bool Overlap(double k1, double b1, double k2, double b2)
{
    return (k1 == k2 & b1 == b2);
}

double result(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return x;
}

double result2(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return y;
}



if (Зarallelism(k1, b1, k2, b2) )
{
    Console.WriteLine("Прямые паралельны. ");
}
else if ( Overlap(k1, b1, k2, b2))
{
    Console.WriteLine("Прямые совпали. ");
}
else
{
    double resx = (result(k1, b1, k2, b2));
    double resy = (result2(k1, b1, k2, b2));
    Console.WriteLine($"Точка пересечения прямых {resx}  {resy}");
}

*/





