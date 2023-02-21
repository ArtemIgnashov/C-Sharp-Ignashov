//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray3(int size) // метод для создания рандомного массива с положительными трёхзначными числами
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void Srowarray(int[] array) // метод для вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}

int QuantityEvenNum(int[] array) // метод для нахождения кол ва четных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}


Console.WriteLine("введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray3(size);
Console.WriteLine("Массив: ");
Srowarray(newArray);

int result = QuantityEvenNum(newArray);
if (result == 0)
    Console.WriteLine($"четных элементов массива не найденно!");
else
    Console.WriteLine($"колличество четных элементов массива равняется: {result} ");
*/

//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRondomArray(int size, int minValue, int maxValue) // создали метод для создания рандомного массива
{
    int[] array = new int[size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int Sum(int[] array)// метод нахождения суммы элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
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
Console.WriteLine("Массив: ");
Srowarray(newArray);

int result = Sum (newArray);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях равняется {result}");*/

//Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

void ShowArray(int[] array) // метод для вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}

void ShowDoubleArray(double[] array) // метод для вывода на экран массива double
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}

int[] change1(int[] array)// метод заменяющий отрицательные элементы на положительные
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) array[i] *= -1;
    }
    return array;
}

int quantity(int num) // метод кол ва цифр в числе
{
    int count = 1;

    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int[] CreateRondomArray(int size, int minValue, int maxValue) // метод для создания рандомного массива
{
    int[] array = new int[size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue + 1);

    return array;
}

double[] CreateRemArray(int size) // метод для создания рандомного массива остатков
{
    double[] array = new double [size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = Math.Round(new Random().NextDouble(),4);

    return array;
}

double[] CreateDoubleArray(int size, int[] array1, int[] array2) // метод для создания рандомного массива double
{
    double[] array = new double[size];

    for (int i = 0; i < array1.Length; i++)
        array[i] = array1[i] + (array2[i] / Math.Pow(10, (quantity(array2[i]))));
    return array;
}



Console.WriteLine("введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
/*
Console.WriteLine("введите минимальвый элемент массива целых чисел:  ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите максимальный элемент массива целых чисел:  ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите минимальвый элемент массива дробных чисел:  ");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите максимальный элемент массива дробных чисел:  ");
int max1 = Convert.ToInt32(Console.ReadLine());
*/


double[] newArray = CreateRemArray(size);
Console.WriteLine("Массив целых чисел: ");
ShowDoubleArray(newArray);

/*
double[] newArray1 = CreateRemArray(size, min1, max1);
Console.WriteLine("Массив дробных чисел: ");
ShowArray(newArray1);

int[] ResultArray = CreateDoubleArray(size, newArray, newArray1);
Console.WriteLine("Массив дробных чисел: ");
ShowArray(ResultArray);*/


