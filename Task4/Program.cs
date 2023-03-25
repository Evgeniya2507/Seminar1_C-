// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int n = 1;
int x = 0;
int N = 0;

System.Console.Write("Введите число: ");
N = int.Parse(Console.ReadLine());

while (n <= N)

    if (x == n % 2)
    {
        System.Console.Write(n+" ");
        n = n + 2;
    }
    else
    {
        n = n + 1;
    }
    
        


    

 