// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray()
{
  Console.WriteLine("Введите длину массива: ");
  int arrayLenght = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите значения массива: ");
  int [] array = new int[arrayLenght];
  for (int index = 0; index < arrayLenght; index++)
  {
    array [index] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}

int[] newArray = CreateArray();

Console.WriteLine($"[{String.Join(", ", newArray)}]");