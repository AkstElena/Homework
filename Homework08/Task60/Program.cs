// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray()
{
  int m = 2;
  int n = 2;
  int l = 2;
  int[,,] matrix = new int[m, n, l];
  List<int> numbers = Enumerable.Range(10, 89).ToList();
                     //принимает начальное значение последовательности и количество последовательных целых чисел для генерации
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        int randomIndex = new Random().Next(0, numbers.Count);
        int number = numbers[randomIndex];
        numbers.RemoveAt(randomIndex);
        matrix[i, j, k] = number;
      }
    }
  }
  return matrix;
}

void PrtintArray(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
      }
      Console.WriteLine();
    }
  }
}

int[,,] matrix = CreateArray();
PrtintArray(matrix);