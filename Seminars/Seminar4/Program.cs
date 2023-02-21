// Семинар 4 

// Задача 1 
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*

int Getsum(int num)
{
    int sum = 0;// инициализация рабочей переменной index / условие существования цикла/
   //ихменение рабочей переменной// тело цикла for это только то,что должно повторяться
    for (int current = 0; current <= num; current++)
        sum += current;
    return sum;

 }                                 

 Console.WriteLine("введите число: ");

int Num= Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Getsum(Num));
*/

// Задача 2
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int pow(int num)
{
    int factor = 1;
    for (int cur = 1; cur <= num; cur++)
        factor *= cur;
    return factor;
}

Console.WriteLine("введите число: ");

int Num = Convert.ToInt32(Console.ReadLine());
int result = pow(Num);

Console.WriteLine(result);*/

// Задача 3 
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int quantity(int num)
{
    int count = 1;

    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("введите число: ");

int Num = Convert.ToInt32(Console.ReadLine());

int result = quantity(Num);

Console.WriteLine(result);
*/

// Массивы

/*
int[] CreateRondomArray(int size, int minValue, int maxValue) // создали метод для создания рандомного массива
{
    int[] array = new int[size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Srowarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("введите размер, первое и последнее ");

int size = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRondomArray(size, min, max);
Srowarray (newArray); // в метод отправляется массив целиком

*/