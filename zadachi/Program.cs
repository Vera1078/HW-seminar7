// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void RealnumbersMatrix ()
{
Console.Write("Введите количество строк массива: \t");
int row =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: \t");
int col =Convert.ToInt32(Console.ReadLine());


double[,] matrix = new double[row, col];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Math.Round(new Random().Next(1, 10) + new Random().NextDouble(), 1);
        Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}
}
RealnumbersMatrix ();


// Заполнение массива целыми числами

System.Console.WriteLine();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray (rows, columns, 0, 10);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
             Console.Write($"{result[i, j]} ");
        }
         Console.WriteLine();
    }
    return result;
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void ElementPosition ()
{
System.Console.WriteLine();
Console.Write("Введите номер строки массива: \t");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца массива: \t");
int m = Convert.ToInt32(Console.ReadLine());


    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
    Console.WriteLine("Такого элемента в массиве НЕТ");
    }
    else
    {
    Console.WriteLine($"Элемент ({n},{m}) = {array[n - 1, m - 1]}");
    }
}
ElementPosition ();
    

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine();

 for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array [i, j];
        }
         average =  average / rows;
         Console.Write($"{average:f2}; ");
    }
   