Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int PokazChisel(int n)
{
    if (n<=a) return n;
    else return PokazChisel(n - 1) + PokazChisel(n - 2);
}
//Console.Write($"{PokazChisel(N)}");
Console.Write("Сколько показать первых чисел последовательности? ");
int N = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= N; i++)
{
    Console.Write($"{PokazChisel(i)} ");
}