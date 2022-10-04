﻿int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine()??"0");
    return number;
}

void PrintData(string msg, int value)
{
    System.Console.WriteLine(msg + value);
}

int CountDigitLog(int num)
{
    int digitCount = (int)Math.Log10(num) + 1;
    return digitCount;
}

int CountDigitNum(int num)
{
    int count = 0;
    while(num>0)
    {
        num = num/10;
        count++;
    }
    return count;
}

int CountDigitString(int num)
{
return num.ToString().Length;
}


int num = ReadData("Введите число = ");

// int res1 = CountDigitLog(num);
// int res2 = CountDigitNum(num);
// PrintData("Количество цифр в числе " + num + " (CountDigitLog) равно = ", res1);
// PrintData("Количество цифр в числе " + num + " (CountDigitNum) равно = ", res2);

PrintData("Количество цифр в числе " + num + " (CountDigitLog) равно = ", CountDigitLog(num));
PrintData("Количество цифр в числе " + num + " (CountDigitNum) равно = ", CountDigitNum(num));
PrintData("Количество цифр в числе " + num + " (CountDigitString) равно = ", CountDigitString(num));
