//seminar 7
// Масивы 2 D

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

int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);
*/

//Задача 1
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.

/*
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


int[,] Create2dArray() //метод генирации массива 2D
{
    Console.WriteLine("введите кол-во строк:  ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов:  ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите минимальное значение:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите максимальное значение:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = i+j;
    return array;
}

int[,] newArray = Create2dArray();
ShowArray2D(newArray);
*/

//Задача 2
//Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

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

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < (array.GetLength(0)); i++)
        for (int j = 0; j < array.Length / (array.GetLength(1)); j++)
            if (i % 2 == 0 & j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
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

int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

int[,] newArray1 = ChangeArray(newArray);
ShowArray2D(newArray1);
ShowArray2D(newArray);
*/

//Задача 3
//Задайте двумерный массив.
// Найдите сумму элементов, находящихся на 
//главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int sum(int[,] array)
{
    int current = 0;
    for (int i = 0; i < (array.GetUpperBound(0) + 1); i++)
        for (int j = 0; j < array.Length / (array.GetUpperBound(0) + 1); j++)
            if (i==j) current += array[i, i];
    return current;
}

int[,] newArray = CreateRandon2dArray();
ShowArray2D(newArray);

int result = sum(newArray);
Console.WriteLine($"Сумма элементов диагонали  {result}");
*/

