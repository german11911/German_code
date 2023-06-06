// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// заполение массива целыми случайными числами из диапазона [a,b]
void FillArray(int[] array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(a, b);
}
// печать массива
void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
// счёт чётных значений в массиве
int Findchet (int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2 == 0)
            num ++;
        return num;
}

System.Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
int [] array999 = new int [length];
FillArray(array999,100,999);
System.Console.WriteLine("в массиве ");
PrintArray(array999);
System.Console.WriteLine($"{Findchet(array999)} чётных чисел");