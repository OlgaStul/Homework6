/*   Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)   */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Ввели не корректное число, повторите ввод!");
    }
    return result;
}

int k1 = GetNumber("Задана прямая y = k1*x + b1. Введите k1 = ");
int b1 = GetNumber("Введите b1 = ");
int k2 = GetNumber("Задана прямая y = k2*x + b2. Введите k2 = ");
int b2 = GetNumber("Введите b2 = ");

if(k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке х = {x}, y = {y}");
}


