/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int columns = int.Parse(ReadLine());
Write("Введите число: ");
int num = int.Parse(ReadLine());


int [,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);

if (HaveNum(array, num)) 
{
    Write("Yes");
} else {
    Write("No");
}

int [,] GetArray (int m, int n, int minValue, int maxValue) //метод создания массива
{
    int [,] result = new int [m, n];
    for (int i=0; i < m; i++) 
    {
        for (int j=0; j < n; j++) 
        {
            result [i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int [,] inArray) //метод вывода массива
{
    for (int i=0; i<inArray.GetLength(0); i++) 
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
    WriteLine();
    }
}

bool HaveNum (int [,] inArray, int num) //метод выявления числа
{ 
    foreach (var item in inArray)
    {
        if (num == item)
        return true;
    }
    return false;
}