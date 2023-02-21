 //задача 1

 // Привет напиши два числа что бы определить какое больше

/*
Console.WriteLine("Привет напиши два числа что бы определить какое больше: ");

Console.WriteLine("Введите первое  : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе : ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine($"первое число {num1} больше");
}
else 
{
    Console.WriteLine($"второе число {num2} больше");

}
*/


 //Задача 2
// Введите три числа для нахождения максимального

/*
Console.WriteLine("Введите три числа для нахождения максимального");
Console.WriteLine("Введите первое : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе : ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье : ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(num1,Math.Max(num2,num3));
Console.Write("Максимальное число :  ");
Console.Write(max);
*/


// Задача 3 и 4 


Console.WriteLine("Введите число, что бы узнать четное оно или нет и вывести все четные до этого числа");
Console.WriteLine("Введите число: ");
double num1 = Convert.ToInt32(Console.ReadLine());

double x = num1%2;

if (x == 1)
{
    Console.WriteLine($"число {num1} нечетное! ");
}
else 
{
    Console.WriteLine($"число {num1} четное! ");
}


//Console.WriteLine("Введите число, что бы узнать четное оно или нет и вывести все четные до этого числа");
//Console.WriteLine("Введите число: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все четные числа перед  {num1} :");
int current = 0;
while (current < num1)
{
    Console.Write(current+" ");
    current += 2;
}