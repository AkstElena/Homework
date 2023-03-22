// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateArray()
{
  int[,] matrix = new int[4, 4];
  int number = 1;
  for (int i = 0, j = 0; j < matrix.GetLength(1)-1; j++)
    {
      matrix[i, j] = number;
      number++;
    }
  for (int j = matrix.GetLength(1)-1, i=0; i < matrix.GetLength(0)-1; i++)
    {
      matrix[i, j] = number;
      number++;
    }
  for (int j = matrix.GetLength(1)-1, i=matrix.GetLength(0)-1; j > 0; j--)
    {
      matrix[i, j] = number;
      number++;
    }
  for (int j = 0, i= matrix.GetLength(0)-1 ; i > 0; i--)
    {
      matrix[i, j] = number;
      number++;
    }
  for (int i = 1, j = 1; j < matrix.GetLength(1)-1; j++)
    {
      matrix[i, j] = number;
      number++;
    }
  for (int j = 2, i=2; j > 0; j--)
    {
      matrix[i, j] = number;
      number++;
    }
    return matrix;
}


void PrtintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] < 10)
        Console.Write($"0{matrix[i, j]}\t");
      else Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
  }
}


int[,] array = CreateArray();
PrtintArray(array);