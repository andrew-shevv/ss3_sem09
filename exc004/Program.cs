// Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

double AtoThePowerOfB(double numberA, double numberB)
{
    if (numberB > 1)
    {
        return numberA * AtoThePowerOfB(numberA, numberB - 1);
    }
    else if (numberB < 1)
    {
        return AtoThePowerOfB(numberA, numberB + 1) / numberA;
    }
    else return numberA;
}

Console.Write("Input first number: ");
double numA = double.Parse(Console.ReadLine()!);

Console.Write("Input second number: ");
double numB = double.Parse(Console.ReadLine()!);

Console.WriteLine($"{numA}^{numB}={AtoThePowerOfB(numA, numB)}");