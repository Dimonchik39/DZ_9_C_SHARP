// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;
// int m = 2;
// int n = 3;
Ackermann(m, n);

int Ackermann(int m2, int n2)
{
    if (m2 == 0) return n2 + 1;
    if (m2 > 0 && n2 == 0)
    {
        return Ackermann(m2 - 1, 1);
    }
    return Ackermann(m2 - 1, Ackermann(m2, n2 - 1));
}

int result = Ackermann(m, n);
Console.WriteLine(result);
