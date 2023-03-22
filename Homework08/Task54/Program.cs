// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrix()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int[,] SortMaxToMinRows(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] > matrix[i, j-1])
      {
        int tmp = matrix[i, j-1];
        matrix[i, j - 1] = matrix[i, j];
        matrix[i, j] = tmp;
        j = 0;
      }
    }
  }
  return matrix;
}


int[,] array = CreateMatrix();
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine("Элементы каждой строки заданного массива упорядочены по убыванию");
PrintMatrix(SortMaxToMinRows(array));
