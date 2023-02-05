/*  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())     */


Console.WriteLine("Введите М чисел, разделяя их пробелами");
string resultStr = Console.ReadLine();
string[] result = resultStr.Split();
int[] arr = Array.ConvertAll(result, int.Parse);

int PositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
int count = PositiveNumbers(arr);
Console.WriteLine($"Количесво положительних чисел - {count}");