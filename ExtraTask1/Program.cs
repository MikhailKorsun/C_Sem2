// Напиши программу, где вводим три числа, а потом выводим сумму только положительных чисел.
int result = 0;
for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"Введите {i} число");
    int number = Convert.ToInt32(Console.ReadLine());
    if ( number > 0) 
    {
        result = result + number;
    }
    
}
Console.WriteLine($"Сумма положительных чисел = {result}");