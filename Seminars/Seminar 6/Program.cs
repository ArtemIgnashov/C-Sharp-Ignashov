// Seminar 6

// два типа данных: ссылочные типы, 

/*
int[] CreateRondomArray(int size, int minValue, int maxValue) // создали метод для создания рандомного массива
{
    int[] array = new int[size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

void Srowarray(int[] array) // метод для вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите минимальвый элемент:  ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите максимальный элемент:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRondomArray(size, min, max);
Srowarray(newArray);
ReverseArray(newArray);
Srowarray(newArray);
*/

// Задача 1
//Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

/*
bool Sum(int a, int b, int c)
{
    return (a + b > c && a + c > b && c + b > a);
}

Console.WriteLine("введите длинну первого отрезка:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите длинну второго отрезка:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите длинну третьего отрезка:  ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (Sum(num1, num2, num3)) Console.WriteLine("Треугольник может существовать!");
else Console.WriteLine("Треугольник НЕ может существовать!");
*/

//Задача 2
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*
double[] Fibo(int size, int num1, int num2)
{
    double[] array = new double[size];

    for (int i = 2; i < array.Length; i++)
    {
        array[0] = num1;
        array[1] = num2;
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void Showarray(double[] array) // метод для вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите первое число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

double[] newArray = Fibo(size, num1, num2);
Console.WriteLine("Массив: ");
Showarray(newArray);*/

// Задача 3
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] CreateRondomArray(int size, int minValue, int maxValue) // создали метод для создания рандомного массива
{
    int[] array = new int[size]; // выделить память под массив размером size

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int[] CreateCopyArray(int[] array)
{
    int[] array1 = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        array1[i] = array[i];
    return array1;
}

void Showarray(int[] array) // метод для вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите минимальное число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите максисальное число:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRondomArray(size, num1, num2);
int[] Arraynew = CreateCopyArray(newArray);
Showarray(newArray);
newArray[0] = 200;
Showarray(newArray);
Showarray(Arraynew);
*/
