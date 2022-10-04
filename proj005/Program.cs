Console.Write("Введите имя пользоватея: ");
string usermame = Console.ReadLine()??"0";

if (usermame.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(usermame);
}