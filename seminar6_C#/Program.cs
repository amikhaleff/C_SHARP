string[,] matrix = {
    {" ", " ", " ", " "," "," "},
    {" ", " ", " ", " "," "," "},
    {" ", "@", " ", " "," "," "},
    {" ", " ", " ", "*"," "," "},
    {" ", " ", " ", " "," "," "},
    {" ", " ", " ", " "," "," "}};
int X = 1;
int Y = 2;
int count = 0;
void WriteArrayMatrix(string[,] matrix)
{
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            Console.Write(matrix[y,x] + " ");
        }
        Console.WriteLine();
    }
}
void WriteCoordinates(int X, int Y, int count)
{
    Console.WriteLine($"X = {X} Y = {Y} Count = {count}");
}
int BonusCreator(string[,] matrix, int X, int Y, int count)
{
    while(matrix[Y,X] == "*")
    {
        count++;
        matrix[Y,X] = " ";
        int newCoordBonusY = new Random().Next(0,matrix.GetLength(0));
        int newCoordBonusX = new Random().Next(0,matrix.GetLength(1));
        matrix[newCoordBonusY,newCoordBonusX] = "*"; 
    }
    return count;
}
void Game(string[,] matrix, int X, int Y,int count)
{
    while (true)
    {
        matrix[Y,X] = " "; // в матрице начинается с Y
        ConsoleKeyInfo user_keyTab = Console.ReadKey();// переменная для клавиши
        if(user_keyTab.Key == ConsoleKey.W) Y--;// клавиши W S A D
        if(user_keyTab.Key == ConsoleKey.S) Y++;
        if(user_keyTab.Key == ConsoleKey.A) X--;
        if(user_keyTab.Key == ConsoleKey.D) X++;
        if(Y < 0) Y = 0;
        if(X < 0) X = 0;
        if(X > matrix.GetLength(1)-1) X = matrix.GetLength(1)-1;
        if(Y > matrix.GetLength(0)-1) Y = matrix.GetLength(0)-1;
        count = BonusCreator(matrix,X,Y,count);
        matrix[Y,X] = "@";
        Console.Clear();
        WriteArrayMatrix(matrix);
        WriteCoordinates(X,Y,count);
    }  
}
WriteArrayMatrix(matrix);
Game(matrix,X,Y,count);

