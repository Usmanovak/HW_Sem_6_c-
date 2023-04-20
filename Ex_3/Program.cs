/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;
using static System.Console;

Clear();
Write("rows: ");
int rows = int.Parse(ReadLine());
Write("columns: ");
int columns = int.Parse(ReadLine());

int[,]array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double [] r = GetMean(array);

WriteLine($"Среднее арифметическое элементов столбцов = {String.Join(" ",r)}");

int[,]GetArray (int m, int n, int min, int max)
{
    int[,] result = new int [m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result [i,j] = new Random().Next(min, max +1);
        }
    }
    return result;
}

double [] GetMean (int [,] array)
{
    double [] result = new double [array.GetLength(1)];
    for (int j=0; j<array.GetLength(1); j++) 
    {
        double sum = 0;
        for (int i=0; i<array.GetLength(0); i++)
            {
                sum += array [i, j];
            }
            result [j] = sum / rows;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Write($"{array[i,j] } ");
        }
        WriteLine();
    }
}