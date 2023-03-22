// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray()
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

void PrtintArray(int[,] matrix)
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

void MultMatrixs(int[,] matrix1, int[,] matrix2)
{
  if (matrix1.GetLength(1) == matrix2.GetLength(0))
  {
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // количество строк как в первой, количество столбцов как во второй
    for (int i = 0; i < matrix1.GetLength(0); i++)  // проходим по строкам первой матрицы, первый множитель произведении строка
    {
      for (int j = 0; j < matrix2.GetLength(1); j++) // далее по столбцами второй матрицы, второй моножитель произведения строка
      {
        for (int k = 0; k < matrix2.GetLength(0); k++) // так как количество столбцов первой равно количеству строк второй, вводим переменную для их перебора
        {
          newMatrix[i, j] += matrix1[i, k] * matrix2[k, j]; // новое значение матрицы это допустим для второго элемента 10 * 01 + 11 * 10 + 12*20 + 13 * 30 .... ik * kj 
        }
        Console.Write(newMatrix[i, j] + "\t");
      }
      Console.WriteLine();
    }
  }
  else Console.WriteLine("Матрицы не совместимы");

}

int[,] matrix1 = CreateArray();
int[,] matrix2 = CreateArray();
PrtintArray(matrix1);
Console.WriteLine();
PrtintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
MultMatrixs(matrix1, matrix2);

