
// У нас есть график, где даны отрезок 1 - (х1; x2) и отрезок 2 (х3, x4)
// ​Необходимо составить код, который находит их пересечение.
// Пересечением двух отрезка 1 и 2 могут быть - отрезок, точка или ничего
// С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».

Console.WriteLine("Введите координаты первого отрезка: ");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второго отрезка: ");
Console.Write("x3 = ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("x4 = ");
int x4 = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (x1 > x2)
    (x1, x2) = (x2, x1);
if (x3 > x4)
    (x3, x4) = (x4, x3);
if (x2 < x3 || x4 < x1)
    Console.WriteLine("Интервалы не пересекаются");
else
{
    if (x1 <= x3 && x2 <= x4)
    Console.WriteLine($"Пересечение в интервале от {x3} до {x2}");
    if (x1 <= x3 && x4 <= x2)
    Console.WriteLine($"Пересечение в интервале от {x3} до {x4}");
    if (x3 <= x1 && x2 <= x4)
    Console.WriteLine($"Пересечение в интервале от {x1} до {x2}");
    if (x3 <= x1 && x4 <= x2)
    Console.WriteLine($"Пересечение в интервале от {x1} до {x4}");
}