Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Таблица кубов: ");
for (int i=1;i<=n;i++)
{
  int k = i*i*i;
  Console.Write("| ");
  Console.Write($"{k} | ");
}