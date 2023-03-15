// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


Console.Write("Введите первое число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int max = Convert.ToInt32(Console.ReadLine());;
NaturalToLow(min, max);


void NaturalToLow(int min, int max)
{
    if (min > max) return;
    if(min % 2 == 0) Console.Write($"{min}\t");    
    {
        NaturalToLow(min + 1, max );
        System.Console.WriteLine();
    }
}