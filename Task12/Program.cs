// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два целых числа для проверки: ");
Console.Write("Первое: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % secondNumber == 0)
    Console.WriteLine("Число {0} кратно числу {1}", firstNumber, secondNumber);
else  Console.WriteLine("Число {0} некратно числу {1}, остаток от деления: {2}", firstNumber, secondNumber, firstNumber % secondNumber);