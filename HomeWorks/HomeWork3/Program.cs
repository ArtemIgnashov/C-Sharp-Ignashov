// Задача 19 
// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

/*
int function(int num)
{
    int n = 0;

    while (num != 0)
    {
        n = n * 10 + num % 10;
        num = num / 10;
    }
    return n;
}

bool polin(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.WriteLine("число ясвляется полиндромом!");
        return true;
    }
    else
    {
        Console.WriteLine("число НЕ ясвляется полиндромом!");
        return false;
    }
}



Console.WriteLine("введите число: ");

int Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("отраженное число: ");

int result = function(Num);

Console.WriteLine(result);

Console.WriteLine(polin(Num, result));
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double hypotenuse(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2)+ Math.Pow(za - zb, 2));
}

Console.WriteLine("последовательно введите координаты точек: ");

Console.Write("xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("za: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("xb: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("yb: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("zb: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длинна отрезка равна " + Math.Round(hypotenuse(xa, ya, za, xb, yb, zb),2));
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cube (double num)
{
    double counter = 1;
    double i = 0;
    while (counter <=num)
    {
        i=Math.Pow(counter, 3);
        Console.Write(i+" ");
        counter++;
    }
    
}

Console.WriteLine("введите число: ");

double Num = Convert.ToDouble(Console.ReadLine());

cube(Num);
