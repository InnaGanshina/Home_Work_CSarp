/*Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы*/


int CreateNumbers()
{
    Console.WriteLine("Введите натуральное число: ");
    int num = Convert.ToInt32(Console.ReadLine()); ;
    return num;
}

void PrintDigit(int num1, int num2, bool up)
{
    
    if (up)
    {
        if (num1 <= num2)
        {
            Console.Write($"{num1} ");
            PrintDigit(num1 + 1, num2, up);
        }
    }
    else
    {
        if (num2 <= num1)
        {
            Console.Write($"{num1} ");
            PrintDigit(num1 - 1, num2, up);
        }
    }
}

int m = CreateNumbers();
int n = CreateNumbers();

if (m>=0 && n>=0)
{
    Console.Write($"m={m} n={n} -> ");

    PrintDigit(m, n, (m <= n));
}
else
{
  Console.Write( "Введено неверное значение!"); 
}
