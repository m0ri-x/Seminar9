// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

if (numberN < numberM)
{
    Console.WriteLine("Число N не может быть больше M");
}
else
{
    int sum = SumCount(numberN, numberM);
    Console.WriteLine(sum);
}

int SumCount(int n, int m)
{
    if (n < m) return 0;
    int sum = SumCount(n - 1, m);
    return sum += n;
}