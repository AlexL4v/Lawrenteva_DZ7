// Задача 1
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
void FillArrayRandom(int a, int b)
{
    double[,] matrix;
    matrix = new double[a, b];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*10;
            Console.Write(matrix[i,j] + " ");

        }
        Console.WriteLine();
    }
}
FillArrayRandom(4,4);
*/

// Задача 2
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
/*
void ElementArray(int n, int m)
{
    int a = 5;
    int[,] matrix = new int[a, a];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
    if (n <= a && m <= a)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (n == i + 1 & m == j + 1) Console.WriteLine(matrix[i, j]);
            }
        }
    }
    else Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("Введите первую позицию элемента массива");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию элемента массива");
int numB = Convert.ToInt32(Console.ReadLine());

ElementArray(numA, numB);
*/

// Задача 3
// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticArray(int n, int m)
{
    
    int[,] matrix = new int[n, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
    
    for (int i = 0; i < m; i++)
    {
        double sum = 0;
        
        for (int j = 0; j < n; j++)
        {
            sum = sum + matrix[j,i];
            
        }
        Console.Write(sum/n + " ");
    }
   
    
}
ArithmeticArray(4,4);