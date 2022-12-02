// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами

double[,] FillArrayRandom(double[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * (-10)+5;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0:f1}", array[i,j]);
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}


double[,] array = new double[3,4];
FillArrayRandom(array);
PrintArray(array);


