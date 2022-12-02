// Создайте двуменрый массив, заполните его случайными числами. Найдите сумму элементов на главной диагонали

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

int SumOfMainDiagonal(int[,] array, int m)
{
    int sum = 0;
    for(int i = 0; i < m; i++)
    {
        sum += array[i,i];
    }
    return sum;
}
int n = 3;
int m = 4; 
int s = 0;
if (n < m) s = n;
else s = m;
int[,] array = new int[n,m];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Sum = {SumOfMainDiagonal(array, s)}");

