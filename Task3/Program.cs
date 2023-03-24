// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int i = 0;
int x = 0;

Console.Write("Введите число: ");
i = int.Parse(Console.ReadLine());

if (x == i % 2)
{
   Console.Write(i);
   Console.WriteLine(" - чётное число");
}

else
{
    Console.Write(i);
    Console.WriteLine(" - нечётное число");
}