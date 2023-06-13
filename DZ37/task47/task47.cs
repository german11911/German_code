//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArrayDouble(double[,] array, double a)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = (new Random().NextDouble()*2-1)*a;
}
}
void PrintArray(double[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j]}    ");
        System.Console.WriteLine();
        }
}

System.Console.Write("Введите количество строк - >");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов - > ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение диапазона: ");
double a = Convert.ToDouble(Console.ReadLine());
double[,] array = new double [rows,cols];
FillArrayDouble(array, a);
PrintArray(array);