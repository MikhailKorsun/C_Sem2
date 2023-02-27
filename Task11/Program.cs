//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

Random rand= new Random();
int number = rand.Next(100,1000);
Console.WriteLine("Случайное число: {0}", number);
number = (number % 10) + ((number / 100)*10);
Console.WriteLine("Полученное число: {0}", number);