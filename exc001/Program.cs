// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void ListNumbers(int number)
{
    if (number > 0)
    {
        ListNumbers(number - 1);
    }
    else return;

    Console.Write(number + " ");
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);

ListNumbers(num);