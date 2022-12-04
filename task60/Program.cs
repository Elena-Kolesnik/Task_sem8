// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

WriteLine("Сформирован трёхмерный массив из неповторяющихся двузначных чисел: ");
int[,,] ThreeDArray = new int[2, 2, 2];
GetArray(ThreeDArray);
PrintArray(ThreeDArray);
WriteLine();


void PrintArray(int[,,] array)
{
    for (int i = 0; i < ThreeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeDArray.GetLength(1); j++)
        {
            WriteLine();
            for (int k = 0; k < ThreeDArray.GetLength(2); k++)
            {
                Write($"{ThreeDArray[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void GetArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}
