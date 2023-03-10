// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void NewArray(int[,] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array) 
{
    int temp;
    for (int rowNumber = 0; rowNumber < array.GetLength(0); rowNumber++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[rowNumber, j] < array[rowNumber, j + 1])
                {
                    temp = array[rowNumber, j];
                    array[rowNumber, j] = array[rowNumber, j + 1];
                    array[rowNumber, j + 1] = temp;
                }
            }
        }
    }
    return array;
}

int[,] FillArray(int m, int n) 
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}



int EnterData(string text) 
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int m = EnterData("Введите количество строк массива: ");
int n = EnterData("Введите количество столбцов массива: ");

int[,] array = FillArray(m, n);

array = SortArray(array);

NewArray(array);
