
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

void SumDiagArray(int[,] matrix)
{
    int row=matrix.GetLength(1);
    int col=matrix.GetLength(0);
    int len = row < col ? row : col;
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum += matrix[i, i];

    }
    System.Console.WriteLine(sum);
}

int row=7;
int col=5;
int[,] matrix = new int[row, col];
GetArray(matrix);
Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
SumDiagArray(matrix);
