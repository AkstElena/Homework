// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");

string input = Console.ReadLine();
int number;

bool isNumeric = int.TryParse(input, out number);

if (isNumeric)
{
  if (number > 100)
  {
    char thirdChar = input [2];
    Console.WriteLine("Третья цифра заданного числа: " + thirdChar);
  }
  else if (number < -99)
  {
    char thirdChar = input [3];
    Console.WriteLine("Третья цифра заданного числа: " + thirdChar);
  }
  else Console.WriteLine("У данного числа нет третьей цифры");
 }
else Console.WriteLine("Необходимо вводить число, а не текст!");