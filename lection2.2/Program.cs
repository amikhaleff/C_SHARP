void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 30);
        index++;
    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        System.Console.WriteLine(col[pos]);
        pos++;
    }
}

int IndexOf(int[] collection, int find)
{
    int index = 0;
    int count = collection.Length;
    int position = -1;


    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}



int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int position=IndexOf(array, 4);

if(position>=0)
{
    System.Console.WriteLine("Index = "+ position);
}
else
{
    System.Console.WriteLine("Index Not Found");
}







