void ZADACHA_53()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(double[,] matrix, double min, double max)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
            }
        }
    }

    void NewArray(double [,] matrix)
    {
        int i = 0;
        int i_max = matrix.GetLength(0) - 1;
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            (matrix[i,j],matrix[i_max,j])=(matrix[i_max,j],matrix[i,j]);
        }
    }


    void PrintArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,7}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    double min = ReadData("Введите min: ");
    double max = ReadData("Введите max: ");
    double[,] matrix = new double[m, n];
    Console.WriteLine();
    GetArray(matrix, min, max);
    PrintArray(matrix);
    NewArray(matrix);
    System.Console.WriteLine();
    PrintArray(matrix);
    System.Console.WriteLine();
}
ZADACHA_53();

