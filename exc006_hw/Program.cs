// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetween(int numberA, int numberB)
{
    if (numberA < numberB)
    {
        return numberA + SumBetween(numberA + 1, numberB);
    }
    else return numberA;
}

Console.Write("Input first(smaller) number: ");
int numA = int.Parse(Console.ReadLine()!);

Console.Write("Input second(bigger) number: ");
int numB = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumBetween(numA, numB));