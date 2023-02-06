// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);


//-----------Методы-------------------------------------------------
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}*/

// Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, 
// а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.Write("Введите значение элемента: ");
int element = int.Parse(Console.ReadLine()!);
if(FindElement (array, element))
{
    Console.WriteLine("Элемент найден");
}
else
{
    Console.WriteLine("Элемент не найден");
}


//-----------Методы-------------------------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool FindElement (int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == el) return true;
        }
    }
    return false;
}*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();
GetSum(array);


//-----------Методы-------------------------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetSum (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            Console.Write($"{ sum / array.GetLength(0)}; ");
    }
}