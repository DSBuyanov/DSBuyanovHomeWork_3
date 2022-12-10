// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int n = 8;
int[] arry = new int[n];
int[] GetNewArry(int[] arry)
{
    for (int i = 0; i < arry.Length; i++)
    {
        Console.Write($"Введите элемент массива по индексом {i}:\t ");
        arry[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < arry.Length; i++)
    {
        Console.Write(arry[i] + " ");
    }
    return arry;
}
void Skobk(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
Skobk(arry);

