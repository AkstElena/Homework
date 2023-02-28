// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное чиcло:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
//   Console.WriteLine("Вторая цифра введенного числа: " + (number/10)%10);
// else Console.WriteLine("Введено некорретное число! Необходимо ввести трехзначное число");

Console.WriteLine("Введите трехзначное чиcло:");
string input = Console.ReadLine();
int number;

bool isNumeric = int.TryParse(input, out number);

if (isNumeric)
{
  if (number > 99 && number < 1000)
  {
    char secondChar = input [1];
    Console.WriteLine("Вторая цифра введенного числа: " + secondChar);
  }
  else Console.WriteLine("Введено некорретное число! Необходимо ввести трехзначное число");
 }
else Console.WriteLine("Необходимо вводить число, а не текст!");
