// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number1, number2);

int NaturalNumbers(int num1, int num2)
{
    if (num1 < num2) return num1 += NaturalNumbers(num1 + 1, num2);
    return num2;
}

int result = NaturalNumbers(number1, number2);
Console.WriteLine(result);