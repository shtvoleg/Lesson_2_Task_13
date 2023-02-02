﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();				                // очистка консоли
Console.WriteLine("Введите число: ");		    // ввод числа 
int num = Convert.ToInt32(Console.ReadLine());
int ost1 = 0, ost2 = 0, ost3 = 0;

while (num > 0)
    {
    ost3 = ost2;
    ost2 = ost1;
    ost1 = num % 10;
    num = num / 10;
    }
if (ost3 > 0)
    Console.WriteLine($"Третья  цифра у введённого  числа равна '{ ost3 }'.");
else
    Console.WriteLine($"Третьей цифры у введённого числа нет.");