//HW 8
//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:

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

int[,] newarray = CreateRandom2DArray();
ShowArray2D(newarray);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.



//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.



//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
