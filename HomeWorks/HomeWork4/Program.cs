//Задача 25

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
double pow(double a, double b)
{
    int n = 1;
    double z = a;
    while (n != b)
    {
        z = z * a;
        n++;
    }
    return z;
}

Console.WriteLine("введите два числа, для возвидения числа A в натуральную степень B");
Console.WriteLine("Число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число В: ");
double B = Convert.ToDouble(Console.ReadLine());

double result = pow(A, B);
Console.WriteLine(result);
*/

//Задача 27

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int sum(int num)
{
    int count = 1;
    int n = 0;
    while (num != 0)
    {
        n = n + num % 10;
        num = num / 10;
        count++;
    }
    return n;
}

Console.WriteLine("введите число: ");

int Num = Convert.ToInt32(Console.ReadLine());

int result = sum(Num);

Console.WriteLine(result);
*/
// Задача 29 

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        array[i] = N;
    }
    return array;
}

void SrowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("введите размер: ");

int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("последовательно введите элементы массива: ");


int[] newArray = CreateArray(size);
SrowArray (newArray);
*/