// See https://aka.ms/new-console-template for more information
void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}
double [] array8 = new double [8];
FillArray(array8);
PrintArray(array8);