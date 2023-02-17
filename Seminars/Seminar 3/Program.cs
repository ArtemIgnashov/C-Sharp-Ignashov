// мы сегодня рассматриваем декартову координатную систему, там четыре четверти qadrant
// void  метод который ничего не возвращает, то есть и записывать то что он должен гипотетически  вернуть не нужно.
/*
void GetDiapozon(int qadrant)
{
    if (qadrant == 1) Console.WriteLine("x > 0, y > 0");
    else if (qadrant == 2) Console.WriteLine("x < 0, y > 0");
    else if (qadrant == 3) Console.WriteLine("x < 0, y < 0");
    else if (qadrant == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Wrong input!");

}

Console.WriteLine("Введите номер честверти ");
int numqadrant = Convert.ToInt32(Console.ReadLine());

GetDiapozon(numqadrant);
*/

// Задача 1
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.
/*
void qadrant(double x, double y)
{
    if (x > 0 && y > 0) Console.WriteLine("qadrant = 1");
    else if (x < 0 && y > 0) Console.WriteLine("qadrant = 2");
    else if (x < 0 && y < 0) Console.WriteLine("qadrant = 3");
    else if (x > 0 && y < 0) Console.WriteLine("qadrant = 4");
    else Console.WriteLine("Wrong input!");
}

Console.WriteLine("Введите координатy x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координатy y: ");
double y = Convert.ToDouble(Console.ReadLine());

qadrant(x,y);

*/
// Задача 2
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Power(double Num)
{
    double counter = 1;
    double print = 0;
    while (counter <= Num)
    {
        print = Math.Pow(counter, 2);
        Console.Write(print + " ");
        counter++;

    }
    
}

Console.WriteLine("Введите число: ");
double y = Convert.ToDouble(Console.ReadLine());

Power(y);

*/

//Задача 3
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

double hypotenuse(double xa, double ya, double xb, double yb)
{
    return Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
}

Console.WriteLine("последовательно введите координаты точек: ");
Console.Write("xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("xb: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("yb: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длинна отрезка равна " + Math.Round(hypotenuse(xa, ya, xb, yb),2));

