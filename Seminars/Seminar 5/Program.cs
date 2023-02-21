// Семинар 5 
// работа с масивами

//Задача 1 
//Написать программу, которая определяет сумму отрицательных элементов в массиве.

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
