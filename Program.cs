﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран */

int[] array = new int [8];  

for(int i = 0; i < 8; i++)
{
    
    array [i] = new Random().Next(8);
    Console.Write($"{array[i]}");
}
