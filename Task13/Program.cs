﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int character = 0;
if (number >= 100) 
{
    while ((number / 100) > 0)
    {
        character = number % 10;
        number = number / 10;
    }
    Console.WriteLine("Третья цифра слева {0}", character);
}
else
    Console.WriteLine("Данное число не подходит");