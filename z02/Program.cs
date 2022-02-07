// № 02 Даны два числа. Показать большее и меньшее число
int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
Console.WriteLine("Даны два числа   "+ numberA + "   и   " + numberB);
if (numberA > numberB)
    Console.WriteLine("Большее число " + numberA + "   Меньшее число " + numberB);
else 
{
    if (numberA < numberB)
    Console.WriteLine("Большее число " + numberB + "   Меньшее число " + numberA);
    else
    Console.WriteLine("Нет большего и меньшего");
}