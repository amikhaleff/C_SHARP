double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i}={Factorial(i)}");
}


double Fibonacci(int n)// f(i)=F(i-1)+f(i-2); f(1)=1; f(2)=1 Формула Фибоначчи
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}