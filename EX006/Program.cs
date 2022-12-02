// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента
// или указание что такого элемента нет

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

int ElementSearch(int[,] array, int rows, int cols)
{
    int element = 0;
    for(int i = rows; i < array.GetLength(0); i++)
    {
        for(int j = cols; j < array.GetLength(1); j++)
        {
            if(i == rows && j == cols)
            {
                element = array[i,j];
            }
        }
    }
    return element;
}

int n = 3;
int m = 4;
int[,] array = new int[n,m];

FillArrayRandom(array);
PrintArray(array);

Console.WriteLine();
System.Console.WriteLine("введите строку элемента: ");
int rows = int.Parse(Console.ReadLine() !);
System.Console.WriteLine("введите столбец элемента: ");
int cols = int.Parse(Console.ReadLine() !);
if(rows > n || cols > m) 
{
    Console.WriteLine("Такого числа нет в массиве");
}
else
{
    Console.WriteLine($"Элемент {ElementSearch(array, rows-1, cols-1)} ");
}