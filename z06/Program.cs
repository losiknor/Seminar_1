// № 06 Выяснить является ли число чётным
int numberA = new Random().Next(1, 100);
if (numberA % 2 == 0)
Console.WriteLine("Число   " + numberA + "   является чётным");
else Console.WriteLine("Число   " + numberA + "   не является чётным");