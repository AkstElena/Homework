// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

int [][] TriangleOfPascale(int n)
{
  int[][] result = new int[n][];
  result[0] = new int[1] { 1 };
   for (int i = 1; i < n; i++)
  {
    result[i] = new int[i + 1];
    int tmp = 0;
    for (int j = 0; j < i; j++)
    {
      result[i][j] = result[i - 1][j] + tmp;
      tmp = result[i - 1][j];
    }
    result[i][i] = tmp;
    }
  return result;
}

void PrintArray (int [][] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.SetCursorPosition((Console.WindowWidth) / 2 -array[i].Length, i);
    for (int j = 0; j < array[i].Length; j++)
    {
      if (array[i][j] < 10)
      Console.Write(array[i][j] + "  ");
      else Console.Write(array[i][j] + " ");
    }
    Console.WriteLine();
  }
}

PrintArray(TriangleOfPascale(10));

