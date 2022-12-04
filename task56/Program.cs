// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i ++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
    
}

void NumberRowsMinSumElements(int[,] array)
{
    int minRows = 0;
    int sumRows = 0;
    int minSumRows = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRows += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRows += array[i, j];
        if (sumRows < minRows)
        {
            minRows = sumRows;
            minSumRows = i;
        }
        sumRows = 0;
    }
    WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRows + 1} строка");
}
WriteLine("Задайте прямоугольный двумерный массив.");
Write("Введите кол-во строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(ReadLine()!);
int [,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
WriteLine();
NumberRowsMinSumElements(array);


