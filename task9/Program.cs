﻿// Задача №11
// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.


int number = Random.Shared.Next (100, 1000);
Console.WriteLine (number);
int lastDigit = number % 10;
int firstDigit = number / 100;

Console.WriteLine (firstDigit*10 + lastDigit);