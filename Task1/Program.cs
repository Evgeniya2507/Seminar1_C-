// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    int max = a;
    System.Console.Write("Большим числом является ");
    System.Console.WriteLine(a);
}

else
{
    int max = b;
    System.Console.Write("Большим числом является ");
    System.Console.WriteLine(b);
}


