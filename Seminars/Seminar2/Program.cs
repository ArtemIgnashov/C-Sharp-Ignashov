/*Console.WriteLine(10);
double num1 = new Random().Next(1,100);
Console.WriteLine(num1);*/

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