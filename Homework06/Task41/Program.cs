// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа для проверки в одну строку через пробел: ");
string[] input = Console.ReadLine().Split(" ");
int[] array = Array.ConvertAll(input, s => int.Parse(s));

int Summa ()
{
int sum = 0;
for (int index = 0; index < array.Length; index++)
{
  if (array[index] > 0)
  {
    sum++;
  }
}
return sum;
}

Console.WriteLine($"Введены числа: {String.Join(", ", array)}");
Console.WriteLine($"Из введенных чисел {Summa()} больше 0");