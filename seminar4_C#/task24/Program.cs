﻿int ReadData(string msg) // Метод получения данных от пользователя
                         // название с большой буквы
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()?? "0"); // то что вводит пользователь
    return number; // возвращает число
}

int SumDigitOneToA(int numA)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum = sum + i;
        //sum += i;
    }
    return sum;
}

int GaussMethod(int numA)
{
    int sum = ((1 + numA) * numA) / 2;
    return sum;
}


void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int numA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
int sum = SumDigitOneToA(numA);
Console.WriteLine(DateTime.Now-d1);

PrintData("Сумма чисел от 1 до А(simple): ", sum);

DateTime d2 = DateTime.Now;
int sumGaus = GaussMethod(numA);
Console.WriteLine(DateTime.Now-d2);

PrintData("Сумма чисел от 1 до А(gausse): ", sumGaus);

