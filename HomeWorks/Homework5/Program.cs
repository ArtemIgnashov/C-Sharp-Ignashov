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

double Difference(double[] array)// метод разницы между максимальным и минимальным элементом массива
{
    double max = array[1];
    double min = array[1];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    diff = max - min;
    return diff;
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
    double[] array = new double[size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = Math.Round(new Random().NextDouble(), 4);

    return array;
}

double[] CreateDoubleArray(int size, int[] array1, double[] array2) // метод для создания рандомного массива double
{
    double[] array = new double[size];

    for (int i = 0; i < array1.Length; i++)
        array[i] = array1[i] + (array2[i]);
    return array;
}

Console.WriteLine("введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите минимальвый элемент массива целых чисел:  ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите максимальный элемент массива целых чисел:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray1 = CreateRondomArray(size, min, max);
Console.WriteLine("Массив целых чисел: ");
ShowArray(newArray1);

double[] newArray2 = CreateRemArray(size);
Console.WriteLine("Массив дробных  чисел: ");
ShowDoubleArray(newArray2);

double[] ResultArray = CreateDoubleArray(size, newArray1, newArray2);
Console.WriteLine("Массив вещественных чисел: ");
ShowDoubleArray(ResultArray);

double result = Difference(ResultArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равняется = {result} ");


