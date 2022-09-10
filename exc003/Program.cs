// Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DigitSum(int number)
{
    if (number / 10 == 0)
    {
        return number;
    }
    else return number % 10 + DigitSum(number / 10);
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(DigitSum(num));