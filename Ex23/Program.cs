/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.Write("Введите число N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[n];
for (int i = 0; i < array.Length; i++ )
{
    array[i] = Convert.ToInt32(Math.Pow((i+1), 3)); 
}
Console.WriteLine($"Кубы числа от 1 до {n} равны: {string.Join(", ", array)}");