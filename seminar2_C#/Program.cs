void FillArray(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
        collection[i] = new Random().Next(1, 30);

    }

}
void PrintArray(int[] col)
{
    
    for (int pos=0; pos < col.Length; pos++)
    {
        System.Console.Write(col[pos] + " ");

    }
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

