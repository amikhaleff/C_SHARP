﻿int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine()??"0");
    return number;
}

void PrintData(string msg, long value)
{
    System.Console.WriteLine(msg + value);
}

long Factorial(int num)
{
    long res= 1;
    for (int i = 1; i <=num; i++)
    {
        res=res*i;
    }
    return res;
}

int numN = ReadData("Введите число N: ");
long Result= Factorial(numN);
PrintData("Факториал " + numN+ " равен ", Result);
