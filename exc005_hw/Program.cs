// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ListNumbersReverse(int number)
{
    if (number > 0)
    {
        Console.Write(number + " ");
        ListNumbersReverse(number - 1);
    }
    else return;
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);

ListNumbersReverse(num);