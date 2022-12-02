// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое в каждом столбце

int[,] FillArrayRandom(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void Average(int[,] array, int rows, int cols)
{
    
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        System.Console.Write("{0:f1}", sum / rows);
        System.Console.Write("; ");
    }
}

int rows = 2;
int cols = 5;
int[,] array = new int[rows,cols];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
Average(array, rows, cols);
