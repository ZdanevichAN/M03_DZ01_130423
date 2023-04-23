// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Сударь, введите люое число, а я Вам пушну четные что есть меж ним и нулём: ");
int num_last = int.Parse(Console.ReadLine());
string chet_name = " следующие числа являются четными:";
int count = 0;
while(count <=num_last)
{
    if (count%2 == 0)
    {
        chet_name = chet_name + ", " + count;
    }
    count++;
}
Console.WriteLine("От 0 до " + num_last + chet_name);