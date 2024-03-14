/*  Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 

функция ack(n, m)
   если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1))
 */

int CreateNumbers()
{
    Console.WriteLine("Введите натуральное число: ");
    int num = Convert.ToInt32(Console.ReadLine()); ;
    return num;
}

int AkkermanFunc(int n, int m)
{
    if (n==0)
    {
        return m+1;
    }
    if (m==0)
    {
        return AkkermanFunc(n-1,1);
    }
    return AkkermanFunc(n-1,AkkermanFunc(n,m-1));
}

int m = CreateNumbers();
int n = CreateNumbers();

if (m>=0 && n>=0)
{
    Console.Write($"m={m} n={n} -> A(n,m) = ");
    Console.WriteLine(AkkermanFunc(n, m));
}
else
{
  Console.Write( "Введено неверное значение!"); 
}