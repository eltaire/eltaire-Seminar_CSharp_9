// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine("Натуральные числа от " + number + " до 1:");
NaturalRow(number, count);
Console.WriteLine();
void NaturalRow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalRow(n, count + 1);
        Console.Write(count + " ");
    }
}
