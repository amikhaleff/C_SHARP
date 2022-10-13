void ZADACHA_57()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(int[,] matrix, int min, int max, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = new Random().Next(min, max);
            }
        }
    }

    void NewArray(int [,]matrix, int m, int n)
    {
        int[]counts = new int[10];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                counts[matrix[i, j]]++;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"колво {i} = {counts[i]}");
        }

    }



    void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,7}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    int min = ReadData("Введите min: ");
    int max = ReadData("Введите max: ");
    int[,] matrix = new int[m, n];
    int[]counts = new int[10];
    Console.WriteLine();
    GetArray(matrix, min, max, m, n);
    PrintArray(matrix);
    NewArray(matrix, m, n);
    System.Console.WriteLine();
    // PrintArray(matrix);
    System.Console.WriteLine();
}

ZADACHA_57();
