// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] PrintCreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  Console.WriteLine($"Количество строк: {m}");
  Console.WriteLine($"Количество столбцов: {n}");
  Console.WriteLine();
  double[,] array = new double[m, n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(new Random().Next(-9, 10)) + Math.Round(new Random().NextDouble(), 1);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

PrintCreateArray();