// Задача 10

Console.WriteLine("Напишите трёхзначное число и на выходе покажу вторую цифру этого числа");

int num = Convert.ToInt32(Console.ReadLine());
int cur = num/10;
int cur1 = cur%10;
 
Console.WriteLine(cur1);