// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})    ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] FillArray(int l, int m, int n) 
{
    int[] range = new int[1000];
    for (int i = 0; i < 90; i++) range[i] = i + 10; 
    int temp;
    int[,,] array = new int[l, m, n];

    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                temp = new Random().Next(0, 90); 
                if (range[temp] > 0)
                {
                    array[i, j, k] = range[temp];
                    range[temp] = -1;
                }
                else k--;
            }
        }
    }
    return array;
}


PrintArray(FillArray(2, 2, 2));