// Семинар 5 
// работа с масивами

//Задача 1 
//Написать программу, которая определяет сумму отрицательных элементов в массиве.
// мой вариант
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

int sum(int[] array)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {


        if (array[i] < 0)
        {
            s = s + array[i];
        }
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();

    return s;

}


Console.WriteLine("введите размер массива : ");

int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("последовательно введите элементы массива: ");


int[] newArray = CreateArray(size);

Console.WriteLine("сумма всех отрицательных чисел : ");

Console.Write(sum(newArray));

*/

//вариант преподователя 
// генерирующий метод, аналитический метод, преобразующий метод.


int[] CreateRondomArray(int size, int minValue, int maxValue) // создали метод для создания рандомного массива
{
    int[] array = new int[size]; // выделить память под массив размером size

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int[] CreateArray(int size) //метод для ввода данный вручную
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элементов: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int sum(int[] array) //метод для нахождение суммы отрицательных элементов массива
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            s += array[i];
    //Console.Write(array[i] + " ");
    //Console.WriteLine();

    return s;
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
Srowarray(newArray); // в метод отправляется массив целиком

Console.WriteLine("сумма всех отрицательных чисел: ");
Console.WriteLine(sum(newArray));