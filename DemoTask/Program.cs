//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Например:
//78 -> 8
//12-> 2
//85 -> 8

Random rand= new Random();
int number = rand.Next(10,100);
int max = number % 10;
Console.WriteLine(number);
if (max > ((number-max) / 10)) 
    Console.WriteLine($"Наибольшая цифра: {max}");
    else
    Console.WriteLine($"Наибольшая цифра: {(number-max) / 10}");