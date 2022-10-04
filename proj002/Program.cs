internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите Ваше имя");
        string username = Console.ReadLine()?? "0";
        Console.Write("Привет,");
        Console.Write(username);
    }
}