// HomeWork7 

// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

/*
int[,] CreateRandon2dArray(int rows, int colums, int minValue, int maxValue) //метод генирации массива 2D
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

double[,] CreateDoubleRandon2dArray(int rows, int colums) //метод генирации массива double 2D
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = Math.Round(new Random().NextDouble(), 2);
    return array;
}

double[,] CreateRemArray(int rows, int colums, int[,] array1, double[,] array2) //метод генирации массива вещественных чисел 2D
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = array1[i, j] + array2[i, j];
    return array;
}

void ShowArray2D(int[,] array) // метод вывода масива 2D
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowDoubleArray2D(double[,] array) // метод вывода масива double 2D
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("введите кол-во строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите кол-во столбцов:  ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите минимальное значение:  ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите максимальное значение:  ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandon2dArray(rows, colums, minValue, maxValue);
ShowArray2D(newArray);

double[,] newArray1 = CreateDoubleRandon2dArray(rows, colums);
ShowDoubleArray2D(newArray1);

double[,] resultarray = CreateRemArray(rows, colums, newArray, newArray1);
ShowDoubleArray2D(resultarray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

/*
int[,] CreateRandon2dArray() //метод генирации массива 2D
{
    Console.WriteLine("введите кол-во строк:  ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов:  ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимальное значение:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray2D(int[,] array) // метод вывода масива 2D
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReturnValue(int[,] array, int num1, int num2) // метод нахождения элемента
{
    int res = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i < array.GetLength(0) & j < array.GetLength(1))
                res = array[num1, num2];
    return res;
}

bool task(int[,] array, int num1, int num2)
{
    return (num1 < array.GetLength(0) & num2 < array.GetLength(1));
}

int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

Console.WriteLine("введите номер искомого эл-та:  ");
Console.WriteLine("введите стоку:  ");
int num1 = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("введите столбец:  ");
int num2 = Convert.ToInt32(Console.ReadLine()) - 1;



if (task(newArray, num1, num2))
{
    int result = ReturnValue(newArray, num1, num2);
    Console.WriteLine($"элемент под номером ({num1 + 1};{num2 + 1}) = {result}");
}
else Console.WriteLine($"Элемент ({num1 + 1};{num2 + 1}) не входит в массив ");
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandon2dArray() //метод генирации массива 2D
{
    Console.WriteLine("введите кол-во строк:  ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов:  ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимальное значение:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray2D(int[,] array) // метод вывода масива 2D
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageValue(int[,] array1) // метод нахождения среднего арифметического в столбцах
{
    double[] average = new double[array1.GetLength(1)];
    double[] sum = {0};
    for (int i = 0; i < array1.GetLength(1); i++)
        for (int j = 0; j < array1.GetLength(0); j++)
            sum = sum + array1[j, i];
    average = sum / array1.GetLength(0);

    return average;
}

void Showarray(int[] array) // метод для вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(+array[i] + " ");
    Console.WriteLine();
}



int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

int[] array = AverageValue(newArray);
Showarray(array);
*/


int[,] CreateRandon2dArray() //метод генирации массива 2D
{
    Console.WriteLine("введите кол-во строк:  ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов:  ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимальное значение:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray2D(int[,] array) // метод вывода масива 2D
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[] AverageValue(int[,] array1) // метод нахождения среднего арифметического в столбцах
{
    double[] average = new double[array1.GetLength(1)];
    double[] sum = {0};
    for (int i = 0; i < array1.GetLength(1); i++)
        for (int j = 0; j < array1.GetLength(0); j++)
            sum = sum + array1[j, i];
    average = sum / array1.GetLength(0);

    return average;
}

for (int i = 0; i < 4; i++)
{
    int summ = 0;
    for (int j = 0; j < 3; j++)
    {
        summ = summ + array[j, i];
    }
    double average = summ / 3;
    int n = i + 1;
    Console.WriteLine("Avarage for " + n + " column is " + average);
}

int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

