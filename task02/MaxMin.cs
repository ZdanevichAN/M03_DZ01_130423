// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Добрый день товарищ.Счас мы узнаем у кого больше.В этой строке введи размер первого живо: ");
double number_A = double.Parse(Console.ReadLine());
Console.Write("Очень хорошо, теперь введи размер второго ");
double number_B = double.Parse(Console.ReadLine());

if (number_A > number_B)
    {
        Console.WriteLine("У первого(" + number_A + "см) больше второго(" + number_B + "см)на " + (number_A - number_B) + "см");
    }
if (number_B > number_A)
    {
        Console.WriteLine("У второго(" + number_B + "см) больше первого(" + number_A + "см)на " + (number_B - number_A) + "см");
    }
if (number_B == number_A)
    {
        Console.WriteLine("Первый(" + number_B + "см) и второй(" + number_A + "см) - стручковые-братья");
    }