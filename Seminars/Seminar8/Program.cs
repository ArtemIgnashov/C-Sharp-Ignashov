//Seminar 8
// Задача 1 
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 <= array.GetLength(0) &&
        r2 >= 0 && r2 <= array.GetLength(0) && r1 != r2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}



int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

Console.WriteLine("введите номера двух строк и программа поменяет их местами:  ");
Console.WriteLine("введите строку 1:  ");
int str1 = Convert.ToInt32(Console.ReadLine()) -1 ;
Console.WriteLine("введите строку 2:  ");
int str2 = Convert.ToInt32(Console.ReadLine()) -1;
Console.WriteLine();

ChangeRows(newArray, str1, str2);
ShowArray2D(newArray);
*/

// Задача 2 
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 <= array.GetLength(0) &&
        r2 >= 0 && r2 <= array.GetLength(0) && r1 != r2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

int[,] CreateArray()
{
    Console.WriteLine("введите кол-во строк:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("введите кол-во столбцов:  ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = array[i, j] +5;
    return array;
}

int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

//int[,] newArray1 = CreateArray();
//ShowArray2D(newArray1);

//Задача 3
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых 
//расположен наименьший элемент.