/* Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.
 */

 int[] CreateArrayRndInt(int size, int min, int max) //создание произвольного массива
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array, int index) // вывод созданного массива
{
    if (index<array.Length)
    {
        Console.Write($"{array[index]} ");
        PrintArray(array, index+1);
    }
}

void PrintReversArray (int[] array, int index)
{
    if (index>=0)
    {
        Console.Write($"{array[index]} ");
        PrintReversArray(array, index-1);
    }
}

int[] array = CreateArrayRndInt(10,1,20);
PrintArray(array, 0);
Console.Write(" =>  ");
PrintReversArray(array, array.Length-1);
