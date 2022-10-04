//int number = 12; // -999 999
//string name = "Hello, Andrey";
//float x = 5.2f; // 999.54 -999.54

//bool flag = true; // false
//double b = 34.5;
//char type ='A';

//var r = "kjkkwn5335";

//int number = 12;
//Console.WriteLine("Month in year" + (number + number));
//string n = number.ToString(); 
//System.Console.WriteLine("Введите ваше имя");
//string name = Console.ReadLine();// отдает все только строкой
//System.Console.WriteLine("Привет, " + name);
//System.Console.WriteLine(" сколько вам лет?");
//int age = int.Parse(Console.ReadLine()); // int.Parse конвертирует int в string
//System.Console.WriteLine("вам" + age + "лет" );

//System.Console.WriteLine("insert number a");
//int a = int.Parse(Console.ReadLine());
//System.Console.WriteLine("insert number b");
//int b = int.Parse(Console.ReadLine());
//System.Console.WriteLine(a+b);

//if(a>b)
//{
    //Console.WriteLine("число а больше чем b");
//}
//else if(a<b)
//{
  //  Console.WriteLine("число b больше чем a");
//}
//else
//{
  //  Console.WriteLine("число а равно b");
//}

System.Console.WriteLine("Мы попали в игру угадай чисоло");
int secret_number = new Random().Next(1,11);
int attempt = 5;
bool Win = false;
while (attempt>0)
{
    System.Console.WriteLine("Введите число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine()?? "0");
    System.Console.WriteLine(user_number);
    if(user_number>secret_number)
    {
        System.Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if(user_number<secret_number)
    {
        System.Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if(user_number == secret_number) // =присвоить == сравнить
    {
        System.Console.WriteLine(" угадали!");
        Win = true;
        break;
    }
    
    
}
if (Win)
{
    System.Console.WriteLine("Вы победили, возьмите пирожок");
    Console.WriteLine("Осталось попыток" + (attempt-1) );
}else
{
    System.Console.WriteLine("Вы проиграли, секретное число было" + secret_number);
    System.Console.WriteLine("Попробуйте еще разок");
}