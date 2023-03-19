// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateAndPrintArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  Console.WriteLine($"Количество строк: {m}");
  Console.WriteLine($"Количество столбцов: {n}");
  Console.WriteLine();
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return matrix;
}

double[] AverageOfColumns(int[,] matrix)
{
  double[] arrayAverageOfColumns = new double[matrix.GetLength(1)];
  double number = 0;
  int summ = 0;
  int k = 0;
  while (k < arrayAverageOfColumns.Length)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        summ += matrix[i, j];
      }
      number = Convert.ToDouble(summ) / matrix.GetLength(0);
      summ = 0;
      arrayAverageOfColumns[k] = number;
      k += 1;
      number = 0;
    }
  }
  return arrayAverageOfColumns;
}

int[,] matrix = CreateAndPrintArray();
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", AverageOfColumns(matrix))}.");


