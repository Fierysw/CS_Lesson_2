int x1 = Prompt("Введите координату X точки A: ");
int y1 = Prompt("Введите координату Y точки A: ");
int z1 = Prompt("Введите координату Z точки A: ");
int x2 = Prompt("Введите координату X точки B: ");
int y2 = Prompt("Введите координату Y точки B: ");
int z2 = Prompt("Введите координату Z точки B: ");

int Prompt(string message)
{
  Console.Write(message);
  int number = int.Parse(Console.ReadLine()!);
  return number;
}

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  int deltax = x2 - x1;
  int deltay = y2 - y1;
  int deltaz = z2 - z1;
  return Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
}

Console.Write($"Растояние между точками A и B равно {FindDistance(x1, y1, z1, x2, y2, z2):F2} ");

