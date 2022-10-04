
// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]
// table[2,0]   table[2,1]  table[2,2]  table[2,3]  table[2,4]
// table[3,0]   table[3,1]  table[3,2]  table[3,3]  table[3,4]
// table[4,0]   table[4,1]  table[4,2]  table[4,3]  table[4,4]


void FillArray(int[,] tabl)
{
    for (int i = 0; i < tabl.GetLength(0); i++)//GetLength(0)- получение строк массива
    {
        for (int j = 0; j < tabl.GetLength(1); j++)//GetLength(1)- получение столбцов массива
        {
            tabl[i, j] = new Random().Next(1, 11);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]} "); // $"{....} - интерполяция
        }
        Console.WriteLine();
    }
}
int[,] table = new int[4, 5];
// тип данных [,] - значит две размерности__имя=   [строки, столбцы]
PrintArray(table);
FillArray(table);
Console.WriteLine();
PrintArray(table);