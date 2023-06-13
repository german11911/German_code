// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5} ");
        }
       System.Console.WriteLine();      
    }
}
void PrintArray1(double [] array)
{
    foreach (var item in array)
        Console.Write($"{Math.Round(item,2), 5} ");
    System.Console.WriteLine();
}
double [] ColsAverageValue(int [,] array)
{
        double [] result = new double [array.GetLength(1)]; 
        for (int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
sum += array[i,j];
result[j] = Convert.ToDouble(sum/array.GetLength(0));
        }
        return result;
}
System.Console.Write("Введите количество строк - > ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов - > ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
double [] colsAvarageValue = ColsAverageValue(array);
PrintArray1(colsAvarageValue);