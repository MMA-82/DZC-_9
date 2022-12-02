Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");

int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    else
    {
        if ((n != 0) && (m == 0)) return Akerman(n - 1, 1);
        else return Akerman(n - 1, Akerman(n, m - 1));
    }
}
Console.Write($"Результат вычисления функции Акермана для заданных N и M, A({N},{M})= " + Akerman(N, M));
