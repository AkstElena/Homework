// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)  // функция для заполнения сообщения, любого от пользователя
{
  System.Console.Write(message);
  string value = Console.ReadLine();
  int result = Convert.ToInt32(value);
  return result;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
  Console.WriteLine("Вы ввели не трехначное число, пожалуйста повторите ввод");
  return;
}

Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");