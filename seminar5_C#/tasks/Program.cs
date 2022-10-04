
Console.Clear();

int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine()??"0");
    return number;
}

int[] Fill1DArray(int len, int lowBord, int highBord)
{
    int[]array= new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i]= new Random().Next (lowBord,highBord+1);
    }
    return array;
}

void Print1DArray(int []array)
{
        for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;
    }
    System.Console.WriteLine("["+string.Join(", ", array)+"]");
}

bool FindNumber(int num, int[]array)
{
    // foreach (var item in array)
    // {
    //     if (item==num) return true;
        
    // }
    // return false;
    return array.Contains(num); //ищет в какомто массиве, элемент в скобках (true,false)
}

int arrayLen=ReadData("Введите длину массива ");
int lowBord=ReadData("Введите нижнюю границу массива: ");
int highBord=ReadData("Введите верхнюю границу массива: ");
int[]array= Fill1DArray(arrayLen,lowBord,highBord);
System.Console.WriteLine("["+string.Join(", ", array)+"]");
Print1DArray(array);
System.Console.WriteLine(FindNumber(1,array));
