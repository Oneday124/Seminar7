// Задайте двумерный массив размером mxn, каждый элемент массива находится по формуле: А = m + n
// Выведите массив на экран

int[,] FillArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
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
System.Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine() !);
System.Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine() !);
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
