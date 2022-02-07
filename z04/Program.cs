// № 04 Найти максимальное из трех чисел
int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
int numberС = new Random().Next(1, 100);
Console.WriteLine("Даны три числа   "+ numberA + "   ;   " + numberB + "   ;   " + numberС);
int max = numberA;
if (numberB > max)
max = numberB;
if (numberС > max)
max = numberС;
Console.WriteLine("Максимальное число   " + max);