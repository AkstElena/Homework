// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SummNumInRowsMatrix(int[,] matrix)
{
  int [] summArray = new int [matrix.GetLength(0)];
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }
    // Console.WriteLine($"Сумма чисел {i + 1} столбца равна {sum}");
    summArray[i] = sum;
    sum = 0;
  }
  int minSumm = summArray[0];
  int indexOfMinSumm = 0;
  for (int k = 0; k < summArray.Length; k++)
  {
    if (summArray[k] < minSumm)
    {
      minSumm = summArray[k];
      indexOfMinSumm = k;
    }
  }
  return indexOfMinSumm;
}


int[,] array = CreateArray();
PrtintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {SummNumInRowsMatrix(array)+1} строка");