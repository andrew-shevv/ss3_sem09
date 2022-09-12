// Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Ackermann(int firstNum, int secondNum)
{
    if (firstNum == 0)
    {
        return secondNum + 1;
    }
    else if (firstNum > 0 && secondNum == 0)
    {
        return Ackermann(firstNum - 1, 1);
    }
    else if (firstNum > 0 && secondNum > 0)
    {
        return Ackermann(firstNum - 1, Ackermann(firstNum, secondNum - 1));
    }
    else return -1;
}

const int FIRSTNUMBER = 2;
const int SECONDNUMBER = 3;

Console.Write(Ackermann(FIRSTNUMBER, SECONDNUMBER));