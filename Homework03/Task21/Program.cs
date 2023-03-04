// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int[] pointA = new int[3];
// Console.WriteLine("Введите координаты (X, Y, Z) точки A в 3D пространстве"); ;
// for (int index = 0; index < pointA.Length; index++)
// {
//   pointA[index] = Convert.ToInt32(Console.ReadLine());
// }

// int[] pointB = new int[3];
// Console.WriteLine("Введите координаты (X, Y, Z) точки B в 3D пространстве");
// for (int index = 0; index < pointB.Length; index++)
// {
//   pointB[index] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Координаты точки A: (" + string.Join(", ", pointA) + ")");
// Console.WriteLine("Координаты точки B: (" + string.Join(", ", pointB) + ")");

// double distance = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
// Console.WriteLine("Расстояние между точками A и B = " + Math.Round(distance, 2));


void Coordinates(int[] point)
{
  int length = point.Length;
  for (int index = 0; index < point.Length; index++)
  {
    point[index] = Convert.ToInt32(Console.ReadLine());
  }
}

Console.WriteLine("Введите координаты (X, Y, Z) точки A в 3D пространстве");
int[] pointA = new int[3];
Coordinates(pointA);
Console.WriteLine("Введите координаты (X, Y, Z) точки B в 3D пространстве");
int[] pointB = new int[3];
Coordinates(pointB);

Console.WriteLine("Координаты точки A: (" + string.Join(", ", pointA) + ")");
Console.WriteLine("Координаты точки B: (" + string.Join(", ", pointB) + ")");

double distance = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
Console.WriteLine("Расстояние между точками A и B = " + Math.Round(distance, 2));
