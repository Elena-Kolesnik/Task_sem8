// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

int [,] GetArray (int n)
{
    int [,] result = new int [n, n];
    for (int i = 0; i < n; i ++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(0, 10);
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

int[,] ProductOfMatrices(int[,] firstarray, int[,] secondarray) 
{
    int[,] thirdarray = new int[firstarray.GetLength(0), secondarray.GetLength(1)]; 
    
    for (int i = 0; i < thirdarray.GetLength(0); i++) 
    {
        for (int j = 0; j < thirdarray.GetLength(1); j++) 
        {
            thirdarray[i,j] = 0; 
            for (int k = 0; k < firstarray.GetLength(1); k++) 
            { 
                thirdarray[i, j] += firstarray[i, k] * secondarray[k, j]; 
       
            }
        }
    }
    return thirdarray; 
}

WriteLine("Задайте две матрицы.");
Write("Введите количество строк и столбцов первой и второй матрицы: ");
int matrix = int.Parse(ReadLine()!);
int[,] firstarray = GetArray(matrix);
int[,] secondarray = GetArray(matrix);
int[,] thirdarray = ProductOfMatrices(firstarray, secondarray);
WriteLine();
WriteLine("Первая матрица: ");
PrintArray(firstarray);
WriteLine();
WriteLine("Вторая матрица: ");
PrintArray(secondarray);
WriteLine();
WriteLine("Произведение двух матриц: ");
PrintArray(thirdarray);
WriteLine();