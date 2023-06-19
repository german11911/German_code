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
            Console.Write($"{Math.Round(array[i,j],3),10}   ");
        System.Console.WriteLine();
        }
}
// void SortArray2(double[,] array)
// {
// int n = array.GetLength(0);
// int m = array.GetLength(1);
// //System.Console.WriteLine($"строк {n}   столбцов{m}");
// for (int i = 0; i < n; i++)
// {
// for (int l = 0; l < m; l++)
// {
// for (int k = 0; k < n ; k++)
// {
// for (int j = 0; j < m ; j++)
// {
//     if(k < n-1 && j == m-1) if(array[k,j]>array[k+1,0]) (array[k,j],array[k+1,0])=(array[k+1,0],array[k,j]);
//     if(j < m-1 ) if(array[k,j]>array[k,j+1]) (array[k,j],array[k,j+1])=(array[k,j+1],array[k,j]);
//   }}}}}


// task56 : Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ArrayMinRows(double[,] array)
{
double sumMin = 0;
int i=0;
for (int k = 0; k < array.GetLength(0) ; k++)
{
    double sumRow =0;
    for (int j = 0; j < array.GetLength(1); j++) sumRow+=array[k,j];
    if (k == 0) sumMin = sumRow;
    System.Console.WriteLine(Math.Round(sumRow,3));
    if (sumRow < sumMin)
    {
sumMin = sumRow;
i = k;
  }}
  return i;
  }
Console.Clear();
System.Console.Write("Введите количество строк - > ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов - > ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение диапазона: ");
double a = Convert.ToDouble(Console.ReadLine());
double[,] array = new double [rows,cols];
FillArrayDouble(array, a);
PrintArray(array); 
System.Console.WriteLine($"наименьшая сумма элементов у строки {ArrayMinRows(array)+1}");