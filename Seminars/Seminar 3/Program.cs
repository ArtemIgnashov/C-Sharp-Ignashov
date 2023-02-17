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

void qadrant(double x, double y)
{
    if (x > 0 & y > 0) Console.WriteLine("qadrant = 1");
    else if (x < 0 & y > 0) Console.WriteLine("qadrant = 2");
    else if (x < 0 & y < 0) Console.WriteLine("qadrant = 3");
    else if (x > 0 & y < 0) Console.WriteLine("qadrant = 4");
    else Console.WriteLine("Wrong input!");
}

Console.WriteLine("Введите координатy x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координатy y: ");
double y = Convert.ToDouble(Console.ReadLine());

qadrant(x,y);


// Задача 2
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//Задача 3
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.