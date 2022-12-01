Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");

void PrintNumbers(int N)
{
    if (N >= M)
    {
    PrintNumbers(N - 1);
    Console.Write($"{N} ");
    }
}
PrintNumbers(N);
