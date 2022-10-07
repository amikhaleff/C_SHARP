void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void GetArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)// второй вариант i=1
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // j=1
        {
            if (i != 0 && j != 0) // тогда это условие убираем
            {
                 if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
            }
           
        }
    }
}

int[,] matrix = new int[5, 5];
GetArray(matrix);
Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
ChangeArray(matrix);
PrintArray(matrix);

