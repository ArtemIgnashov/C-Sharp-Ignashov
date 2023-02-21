// Задача 19 
// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

double function(double num1)
{
    double curr = 10;
    double y = 1;
    double num2 = (num1 % curr)*(Math.Pow(10,((num1.ToString().Length)-y)));


    while (num2.ToString().Length <= num1.ToString().Length)
    {
        num2 = num2 + (num1 % curr)*(Math.Pow(10,((num1.ToString().Length)-y)));
        curr = curr * 10;
        y--; 
        Console.WriteLine(num1 + "   " + num2);
    }
return num2;



}


Console.WriteLine("введите число мы проверим полиндром ли оно: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(function(num2));


//num1.ToString().Length);


