// № 08 Показать четные числа от 1 до N
int numberA = new Random().Next(1, 50);
Console.WriteLine("Чётные числа от 1 до " + numberA);
int c = 2;
while (c <= numberA)
{Console.WriteLine(c);
c = c + 2;}