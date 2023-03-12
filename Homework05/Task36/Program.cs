// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// В данном случае: индекс 0 четный, индекс 1 нечетный
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int[] GetArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-99, 100);
  }
  return array;
}

int Sum(int[] array)
{
  int summa = 0;
  for (int index = 0; index < array.Length; index++)
  {
    if (index % 2 != 0)
    {
      summa = summa + array[index];
    }
  }
  return summa;
}

// метод, если брать за нечетные позиции первый, третий и т.д. элементы
// int Sum(int [] array)
// {
//   int summa = 0;
//   for (int index = 0; index < array.Length; index++)
//   {
//     if (index%2 == 0)
//     {
//       summa = summa + array[index];
//     }
//   }
//   return summa;
// }

int lenght = Promt("Введите длину массива");
int[] newArray = new int[lenght];
Console.WriteLine($"[{String.Join(", ", GetArray(newArray))}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна: {Sum(newArray)}");