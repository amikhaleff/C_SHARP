void ZADACHA_59()
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
    Console.WriteLine();
    GetArray(matrix, min, max, m, n);
    PrintArray(matrix);

    int minimal = matrix[0, 0];
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] < minimal)
            {
                minimal = matrix[i, j];
                i_min = i;
                j_min = j;
            }

        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"N[{i_min},{j_min}]={minimal} ");
    System.Console.WriteLine();

    int rowRes = m - 1;
    int colRes = n - 1;
    int[,] result = new int[rowRes, colRes];
    int bias_i = 0;
    int bias_j = 0;
    for (int i = 0; i < rowRes; i++)
    {
        if (i == i_min) bias_i++;
        bias_j = 0;
        for (int j = 0; j < colRes; j++)
        {
            if (j == j_min) bias_j++;
            result[i, j] = matrix[i + bias_i, j + bias_j];
        }
    }
    System.Console.WriteLine();
    PrintArray(result);
    System.Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        if (i != i_min)
        {
            for (int j = 0; j < n; j++)
            {
                if (j != j_min)
                    Console.Write("{0,7}", matrix[i, j]);

            }
            System.Console.WriteLine();
        }
    }
    System.Console.WriteLine();
}

ZADACHA_59();

