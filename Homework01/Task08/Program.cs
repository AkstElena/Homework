// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа в промежутке от 1 до " + number + ":");
for (int evenNumber = 2; evenNumber <= number; evenNumber=evenNumber+2)
{
  Console.Write(evenNumber + " ");
}
