// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine ("Введите цифру");
string answer = Console.ReadLine();
int a = Convert.ToInt32 (answer);

if (a == 1) 
{
    Console.WriteLine ("Понедельник");
}
else if (a == 2) 
{
    Console.WriteLine ("Вторник");
}
else if (a == 3) 
{
    Console.WriteLine ("Среда");
}
else if (a == 4) 
{
    Console.WriteLine ("Четверг");
}
else if (a == 5) 
{
    Console.WriteLine ("Пятница");
}
else if (a == 6) 
{
    Console.WriteLine ("Суббота");
}
else if (a == 7) 
{
    Console.WriteLine ("Воскресенья");
}
else
{
    Console.WriteLine ("НЕТ ТАКОГО ДНЯ НЕДЕЛИ");
}
