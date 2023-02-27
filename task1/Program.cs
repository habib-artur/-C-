// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// // a = 25, b = 5 -> да 
// // a = 2, b = 10 -> нет 
// // a = 9, b = -3 -> да 
// // a = -3, b = 9 -> нет

Console.WriteLine ("Введите число");
string answer_A = Console.ReadLine();
int number = Convert.ToInt32 (answer_A);

Console.WriteLine ("Введите второе число");
string avswer_B = Console.ReadLine();
int number2 = Convert.ToInt32 (avswer_B);

if (number == (number2*number2))
{
    Console.WriteLine("ДА"); 
}
else Console.WriteLine("Нет");