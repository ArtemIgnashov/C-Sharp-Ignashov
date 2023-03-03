//Seminar 9 
// Задача 1 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

/*
void Shownum(int num)
{
   Console.Write(num + " ");
   if (num > 1) Shownum(num - 1);
   Console.Write(num + " ");
}

Shownum(5);
*/

// алгоритм сортировки слияния 

// Задача 2 
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int SumOFDigit(int num)
{
    if (num != 0) return SumOFDigit(num / 10) + num % 10;
    else return 0;
}

int result = SumOFDigit(1234);
Console.WriteLine(result);
*/

/*
 f(1234) -> 4 + f(123)   этап погружения в рекурсию 
 f(123) -> 3 + f(12)
 f(12) -> 2 + f(1)
 f(1) -> 1 + f(0)
 f(0) -> 0
 f(1) -> 1 + 0 = 1   этап возвращение в основную программу 
 f(12) -> 2 + 1 = 3
 f(123) -> 3 + 3 = 6
 f(1234) -> 4 + 6 = 10
*/

// Задача 3
// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

/*
void NatureNum(int m, int n)
{
    if (m > n)
    {
        NatureNum(m - 1, n);
        Console.Write(m + " ");
    }
    else if (n > m)
    {
        NatureNum(m, n - 1);
        Console.Write(n + " ");
    }
    else  Console.Write(n + " ");
}

Console.WriteLine("input first");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second");
int N = Convert.ToInt32(Console.ReadLine());
NatureNum(M, N);
*/

// Задача 4
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B.


double Degree(double a, int b)
{
    if ( b > 0) return Degree(a, b - 1) * a;
    else if (b < 0) return (Degree(a, b + 1) * (1 / a));
    else return 1;
}

Console.WriteLine("input first");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input second");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(A, B));

