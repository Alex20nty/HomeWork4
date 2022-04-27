﻿// Задать массив из 8 элементов и вывести их на экран

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while(index < length)
    {
        Array[index] = new Random().Next(1, 50);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($" {array[position]} ");
        position++;
    }
}

int[] newArray = new int[8];
FillArray(newArray);
PrintArray(newArray); 

