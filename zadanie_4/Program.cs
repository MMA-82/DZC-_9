Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Сколько показать первых чисел последовательности? ");
int n = int.Parse(Console.ReadLine() ?? "0");
int PokazChisel(int n)
{
    if (n == a || n == b) return n;
    else return PokazChisel(n - 1) + PokazChisel(n - 2);
}
//Console.Write($"{PokazChisel(N)}");
for (int i = a; i <= n+2; i++)
{
    Console.Write($"{PokazChisel(i)} ");
}