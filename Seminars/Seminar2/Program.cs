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
