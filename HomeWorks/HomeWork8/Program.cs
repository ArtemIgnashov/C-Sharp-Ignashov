//HW 8
//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:

/*
int[,] CreateRandom2DArray()
{
    Console.WriteLine("введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите миниальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortDescending(int[,] array)
{
    int min = 0;
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, n] < min)
            {
                min = array[i, n];
                n++;
                Console.Write(array[i, j] + "\t");
            }
}



int[,] newarray = CreateRandom2DArray();
ShowArray2D(newarray);
SortDescending(newarray);
ShowArray2D(newarray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2DArray()
{
    Console.WriteLine("введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите миниальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(+array[i] + " ");
    }
    Console.WriteLine();
}

int MinSumRow(int[,] array)
{
    int sum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
            if (temp > sum)
            {
                sum = temp;
                index = i;
            }
        }
    }
    return index;
}

int[] MinRow(int[,] array)
{
    int[] minsum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minsum[i] += array[i, j];
        }
    }
    return minsum;
}

int[,] newarray = CreateRandom2DArray();
ShowArray2D(newarray);
int sumarray = MinSumRow(newarray) + 1;
Console.WriteLine("max sum row = " + sumarray);
Console.WriteLine();
Console.WriteLine("массив сумм сторк");
int[] minsum = MinRow(newarray);
ShowArray(minsum);
*/

//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

/*
Результирующая матрица будет:
18 20
15 18*/

int[,] CreateRandom2DArray()
{
    Console.WriteLine("введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите миниальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] array, int[,] array2)
{
    int[,] multiMatrix = new int[array.GetLength(0), array2.GetLength(1)];

    if (array.GetLength(1) != array2.GetLength(0))
        Console.WriteLine("matrix multiplication is not possible");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                multiMatrix[i, j] = 0;

                for (int k = 0; k < array.GetLength(1); k++)
                {
                    multiMatrix[i, j] += array[i, k] * array2[k, j];
                }
            }
        }
    }
    return multiMatrix;
}

int[,] MatrixMultiplication1(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}



int[,] arrayA = { { 2, 4 }, { 3, 2 } };
int[,] arrayB = { { 3, 4 }, { 3, 3 } };

//int[,] arrayA = CreateRandom2DArray();
//int[,] arrayB = CreateRandom2DArray();

ShowArray2D(arrayA);
ShowArray2D(arrayB);

int[,] result = MatrixMultiplication(arrayA, arrayB);
ShowArray2D(result);




//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
