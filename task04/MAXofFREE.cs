// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int count = 1;
int max = 0;
string numbers_name = "Введены следующие числа:";
while(count<=3)
{
    Console.Write("Дорогой друг введи число № " + count+": ");
    int num = int.Parse(Console.ReadLine());
    numbers_name = numbers_name + " " + num;
    
    if (max<num)
    {
        max = num;
    }

    count++;
}
Console.WriteLine(numbers_name + " Максимальное из них: " + max);