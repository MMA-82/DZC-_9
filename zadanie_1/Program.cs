Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");

void PrintNumbers(int n)
{
    if (n >= M)
    {
    PrintNumbers(n - 1);
    Console.Write($"{n} ");
    }
}
PrintNumbers(N);
