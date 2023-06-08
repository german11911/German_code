// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
// сумма элементов на нечётных позициях
int sumnechet (int[] array)
{
    int sumnechet = 0;
    for (int i = 0; i < array.Length; i+=2)
        sumnechet+= array[i];
    return sumnechet;
}
System.Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
int [] array999 = new int [length];
FillArray(array999,-999,999);
System.Console.WriteLine("в массиве ");
PrintArray(array999);
System.Console.WriteLine($"сумма элементов на нечётных позициях равна {sumnechet(array999)}");