/*
Console.Clear();
int
   xa = 100, ya = 1,
   xb = 1, yb = 50,
   xc = 200, yc = 50;


Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x = xa, y = ya;
int count = 0;

while (count < 100000)
{
    int wtf = new Random().Next(0, 3);
    if (wtf == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (wtf == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (wtf == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;

}
*/

/*
Console.WriteLine("Введтите число, а я выведу нужную цифру: ");
//double num1 = new Random().Next(1, 100);
Console.ReadLine();

int[] num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи какую по счету вывести цифру: ");
Console.WriteLine(10);
double num1 = new Random().Next(1, 100);
Console.WriteLine(num1);

*/
/* лекция 

void Fill(int[] coll)

{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
        coll[index] = new Random().Next(1, 10);
        index++;
    }
}

void Print(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection[position] + " ");
        position++;
    }
}

int IndexOf(int[] coll, int find)
{
    int count = coll.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (coll[index] == find)
        {
            position = index;
            break;
        }
        index++;

    }
    return position;
}


int[] array = new int[10];

Fill(array);
Print(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

// семинар 2 
/*
int CutNumber(int number)    // мы написали метод который не работает без return  и делает то что на входе у него number трехзначное число у когорого удаляется второй знак
{
    int sot = number / 100;
    int ed = number % 10;
    int result = sot * 10 + ed;
    return result;             // return это возврат перевенной можно сказать выход из метода

}

bool isEven(int numb)
{
    if (numb % 2 == 0)
        return true;
    else
        return false;     // в этом методе представленно два выхода из методп с использованием bool (все задачи где ответ да или нет)
}


//if (a > 0 && a % 2 == 0) состовное услоовие
int RandNamber = new Random().Next(100, 1000);

int newnumber = CutNumber(RandNamber);

Console.Write("рандомное трехзначное число :");
Console.WriteLine(RandNamber);
Console.Write("Удаляем вторую цифру :");
Console.WriteLine(newnumber);
*/

// Задача 1
/*
int compare(int numb)
{
    int first = numb / 10;
    int second = numb % 10;
    int max = Math.Max(first, second);
    return max;
}

int RandNumber = new Random().Next(10, 100);

int newNumber = compare(RandNumber);

Console.Write($"наибольшая цифра двухзначного числа {RandNumber} является {newNumber}");
*/

// Задача 2
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool multiplicity(int numb, int numb2)
{
    int mult = numb2 % numb;
    if (mult == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Напишите два числа, для проверки является ли второе число кратно первому ");

Console.Write("Напишите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

bool result = multiplicity(first,second);
Console.WriteLine($"ответ {result}");
*/

// Задача 3 
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool square(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
        return true;
    else
        return false;

}

Console.WriteLine("Напишите два числа, для проверки является ли одно число квадратом другого");

Console.Write("Напишите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

bool result = square(first,second);
Console.WriteLine($"result {result}");
*/
