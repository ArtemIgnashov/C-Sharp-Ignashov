//HW9
//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

/*
void OutputOfNaturalNum(int n)
{
    Console.Write(n + " ");
    if (n > 1) OutputOfNaturalNum(n-1);
}

Console.WriteLine("Задайте N: ");
int N = Convert.ToInt32(Console.ReadLine());

OutputOfNaturalNum(N);
*/

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNaturalElements(int m, int n)
{
    if (m > n) return SumNaturalElements(m - 1, n) + m;
    else if (n > m) return SumNaturalElements(n - 1, m) + n;
    else return 0;
}

Console.WriteLine("imput M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput N");
int N = Convert.ToInt32(Console.ReadLine());

int result = SumNaturalElements(M, N);
Console.WriteLine($"суммa натуральных элементов в промежутке от M до N =  {result}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


double Akkerman(double m, double n)
{
    double res = 0;
    if (m == 0) return res = (n + 1);
    else if (m > 0 & n == 0) res = Akkerman(m - 1, 1);
    else if (m > 0 & n > 0) res = Akkerman(m - 1, Akkerman(m, n - 1));
    return res;
}


Console.WriteLine("Задайте N: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте N: ");
double n = Convert.ToDouble(Console.ReadLine());

double res = Akkerman(m,n);
Console.WriteLine($"result = {res} ");
