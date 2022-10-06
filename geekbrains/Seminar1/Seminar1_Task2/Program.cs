﻿// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.Clear();
System.Console.WriteLine("Input 2 numbers and press Enter:");

if (
    int.TryParse(Console.ReadLine(), out int num1)
    && int.TryParse(Console.ReadLine(), out int num2)
  )
{
  System.Console.WriteLine($"Max = {Math.Max(num1, num2)}");
}
else
{
  System.Console.WriteLine("Enter correct number");
}
