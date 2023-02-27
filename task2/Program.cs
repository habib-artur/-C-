// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine ("Введите перво число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

 int min = a;
 int max = a;


if (a > b)
{
    Console.WriteLine("max =" + a);
    Console.WriteLine("min =" + b);
}
else
{
Console.WriteLine ("max =" + b);
Console.WriteLine ("min =" + a);
}
