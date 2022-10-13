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
                Console.Write("{0,2}", matrix[i, j]);
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
    
    
    int i_max = m-1;
    int j_max = n-1;
    matrix[0,0]=1;
    matrix[i_max,j_max]=1;
    
    PrintArray(matrix);

    bool exit=false;
    while(!exit)
    {
        GetArray(matrix, min, max, m, n);
        FindExit(matrix);
        
    }
    
    if(exit) System.Console.WriteLine("Y");
    else System.Console.WriteLine("N");
    PrintArray(matrix);

    void FindExit(int[,]matrix,int i=0,int j=0)
    {
        if(i<0
        || i>i_max
        || j<0
        ||j>j_max
        ||matrix[i,j]==0
        ||matrix[i,j]==4)

        return;
    
    if (i==i_max&&j==j_max)
    {
        exit=true;
    }
    matrix[i,j]=4;
    FindExit(matrix,i+1,j);
    FindExit(matrix,i-1,j);
    FindExit(matrix,i,j+1);
    FindExit(matrix,i,j-1);
// FindExit(matrix,i+1,j+1);
// FindExit(matrix,i-1,j-1);
// FindExit(matrix,i+1,j-1);
//     FindExit(matrix,i-1,j+1);
    }
    
    
    
    System.Console.WriteLine();

    
}

ZADACHA_59();

