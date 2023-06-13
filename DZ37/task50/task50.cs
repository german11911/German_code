// на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}
string FindMean(int[,] array, int a)
{
string result = ("");
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array[i, j] == a)
           result+= $" [{i},{j}]";
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
       System.Console.WriteLine();      
    }
}
System.Console.Write("Введите количество строк - > ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов - > ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите искомое значение: ");
int a = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
Console.WriteLine($"искомое число {a} на позициях :");
Console.WriteLine(FindMean(array,a));