// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand= new Random();
int number = rand.Next(100,1000);
Console.WriteLine("Случайное число: {0}", number);
number =(number % 100)/10;
Console.WriteLine("Полученное число: {0}", number);