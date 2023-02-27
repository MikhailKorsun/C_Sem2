Console.WriteLine("Введите два целых числа для проверки: ");
Console.Write("Первое: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Число {0} является квадратом числа {1}", firstNumber, secondNumber);
}
else 
    if (secondNumber == firstNumber * firstNumber)
    {
        Console.WriteLine("Число {1} является квадратом числа {0}", firstNumber, secondNumber);
    }
    else
    Console.WriteLine("Числа не являются квадратами друг друга");