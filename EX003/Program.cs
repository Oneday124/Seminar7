// Задайте двумерный массив. Найдите элементы у которых оба индекса нечетные. Замените эти элементы на их квадраты

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

int[,] SquareOfOddElements(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
    return array;
}

int[,] array = new int[3,4];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();

SquareOfOddElements(array);
PrintArray(array);
