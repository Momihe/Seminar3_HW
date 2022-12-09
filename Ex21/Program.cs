/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
double x = 0;
Console.WriteLine("Введите координаты первой точки.");
int[] arraya = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите {i+1}-ю координату: ");
    arraya[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите координаты второй точки.");
int[] arrayb = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите {i+1}-ю координату: ");
    arrayb[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Координаты первой точки:[{string.Join(", ", arraya)}]\nКоординаты второй точки: [{string.Join(", ", arrayb)}]");

for (int i = 0; i < 3; i++)
{
double sum = Math.Pow((arraya[i]-arrayb[i]), 2);
x = x + sum;
}
Console.WriteLine($"Расстояние между двумя точками равна: {Math.Round((Math.Sqrt(x)), 2)}");
