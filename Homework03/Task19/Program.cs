// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string input = Console.ReadLine();
int number;

bool isNumeric = int.TryParse(input, out number);

if (isNumeric)
{
  if (number > 9999 && number < 100000)
  {
   if (input[0] == input[4] && input[1] == input[3])
   {
    Console.WriteLine("Введенное пятизначное число является палиндромом");
   }
   else Console.WriteLine("Введенное пятизначное число не является палиндромом");
  }
  else Console.WriteLine("Введенное число не является пятизначным");
}
else Console.WriteLine("Введено не число!");

// Для любого числа меньше 1 000 000 000
// Console.WriteLine("Введите число");
// string input = Console.ReadLine();
// int number;

// bool isNumeric = int.TryParse(input, out number);
// int index = 0;

// if (isNumeric)
// {
//   while (index < (input.Length - 1) && input[index] == input[input.Length - 1 - index])
//   {
//     index++;
//   }
//   if (input[index] == input[input.Length - 1 - index])
//   {
//     Console.WriteLine("Палиндром");
//   }
//   else Console.WriteLine("Не палиндром");
// }
// else Console.WriteLine("Введено не число!");