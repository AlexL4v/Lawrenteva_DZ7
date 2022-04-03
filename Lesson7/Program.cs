// Задача 1
// Задайте двумерный массив размером m×n, заполненный случайными 
// двухзначными целыми числами.
/*
void FillMassiv(int A, int B)
{
    int[,] massiv = new int[A, B];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(-99, 100);
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(">");
}

// Задача 2
// Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
void SumElement(int A, int B)
{
    int[,] massiv = new int[A, B];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = i  + j ;
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 3
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты. 0 - чет
void Kvadrat(int N, int M)
{
     int[,] matrix = new int[N,M];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            if (i == 0 && j == 00 || i % 2 == 0 && j % 2 == 0)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Kvadrat(4,4);
*/
// Задача 4
// Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.

void SumDiagonal(int C)
{
    int[,] diagonal = new int[C, C];
    int sum = 0;
    for (int i = 0; i < diagonal.GetLength(0); i++)
    {
        for (int j = 0; j < diagonal.GetLength(1); j++)
        {
            diagonal[i, j] = new Random().Next(1, 10);
            if (i == j) sum = sum + diagonal[i, j];
            Console.Write(diagonal[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов по диагонали {sum}");
}
SumDiagonal(6);
/*
Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

FillMassiv(m, n);
SumElement(m, n);
*/