﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите 3-значное число: ");
int value = Convert.ToInt32(Console.ReadLine());

int num2 = (value % 100) / 10;

Console.WriteLine($"Вторая цифра = {num2}");