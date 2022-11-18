//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int n1 = num / 100;  //456 / 100 = 4
int n22 = num % 100;

int n2 = n22 / 10;
int n3 = n22 % 10;

System.Console.WriteLine(n1 * 10 + n3);
