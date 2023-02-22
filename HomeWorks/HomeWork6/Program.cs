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
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double lineIntersection(double k1, double b1, double k2, double b2)
{
    double y=0;
    double x=0;
    if 
    //Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2)+ Math.Pow(za - zb, 2));
}



Console.WriteLine("Две прямые вида y = k1 * x + b1: ");

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Длинна отрезка равна " + Math.Round(hypotenuse(xa, ya, za, xb, yb, zb),2));