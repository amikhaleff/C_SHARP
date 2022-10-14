//Сумма чисел от 1 до N

int SumFor(int n)//циклы
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)// рекурсия
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55


// Факториал числа:
int FactorialFor(int n)//циклы
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)// рекурсия
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// Степень числа a в n

int PowerFor(int a, int n)//циклы
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)//рекурсия
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)// математически
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

//Общее решение
//Решение некоторых задач
// В некотором машинном алфавите имеются четыре
//буквы «а», «и», «с» и «в». Покажите все слова,
//состоящие из T букв, которые можно построить из букв
//этого алфавита
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)// условие выхода из рекурсии
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
// FindWords("аисв", new char[5]);

// Как посмотреть содержимое папки?
// Решение некоторых задач


void CatalogInfo(string path, string indent = "") // способ через foreach
{                               //искуственный отступ
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}

void CatalogInfoSec(string path, string indent = "")// способ через массив
{                               //искуственный отступ
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo []catalogs=catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[]files=catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }    
        
   
}
string path = @"/media/andrey/DATA/РАЗРАБОТЧИК PYTHON/projects/test.project_1/lection2.1";
// CatalogInfoSec(path);


// Игра в пирамидки
// Решение некоторых задач
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
if (count > 1) Towers(with, some, on, count - 1);
Console.WriteLine($"{with} >> {on}");
if (count > 1) Towers(some, on, with, count - 1);
}

// Towers();

// Обход разных структур
// Решение некоторых задач
string emp=string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
                // 0     1   2     3     4   5   6    7     8    9   10     11
void InOrderTraversal(int pos = 1)
{
if (pos < tree.Length)
{
int left = 2 * pos;
int right = 2 * pos + 1;
if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
Console.WriteLine(tree[pos]);
if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
}
}
InOrderTraversal();