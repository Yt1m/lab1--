Console.Write("Для проверки введите x: ");
int x = int.Parse(Console.ReadLine());
int x1 = (x / 10 % 100);
int x2 = (x % 10);
int x3 = (x2 * 100 + x1);
Console.WriteLine($"число x = {x3}");