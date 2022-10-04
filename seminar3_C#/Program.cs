Console.Write("Введите номер порядковый номер задачи ");
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA1();
else if (Task == 2) ZADACHA2();
else if (Task == 3) ZADACHA3();
else System.Console.WriteLine("Такой задачи нет в списке");



void ZADACHA1()
{
    System.Console.Write("Введите число: ");
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    if (number < 0) number = number * -1;
    int tempnumber = number;
    int revnumber = 0;
    while (number > 0)
    {
        revnumber = revnumber * 10 + (number % 10);
        number /= 10;
    }
    if (revnumber == tempnumber) System.Console.WriteLine("Это число полиндром");
    else System.Console.WriteLine("Число не полиндром");
}
void ZADACHA2()
{
    System.Console.Write("Введите координату х точки А: ");
    double ax = double.Parse(System.Console.ReadLine() ?? "0");
    System.Console.Write("Введите координату y точки А: ");
    double ay = double.Parse(System.Console.ReadLine() ?? "0");
    System.Console.Write("Введите координату z точки А: ");
    double az = double.Parse(System.Console.ReadLine() ?? "0");

    System.Console.Write("Введите координату х точки B: ");
    double bx = double.Parse(System.Console.ReadLine() ?? "0");
    System.Console.Write("Введите координату y точки B: ");
    double by = double.Parse(System.Console.ReadLine() ?? "0");
    System.Console.Write("Введите координату z точки B: ");
    double bz = double.Parse(System.Console.ReadLine() ?? "0");

    double a = Math.Pow((bx - ax), 2);
    double b = Math.Pow((by - ay), 2);
    double c = Math.Pow((bz - az), 2);

    double Dist = Math.Round((Math.Sqrt(a + b + c)), 2);

    System.Console.WriteLine("Расстояние между точками А и В : " + Dist);

}

void ZADACHA3()
{
  Console.Write("Введите число : ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 0)
    {
        int i = 1;
        for (i = 1; i <= num; i++) Console.Write(Math.Pow(i, 3) + " ");
    }
    else
    {
        int i = -1;
        for (i = -1; i >= num; i--) Console.Write(Math.Pow(i, 3) + " ");
    }
}
System.Console.WriteLine();