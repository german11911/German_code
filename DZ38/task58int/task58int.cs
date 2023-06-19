//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// + сортировка по возрастанию
// void FillArrayDouble(double[,] array, double a)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {for (int j = 0; j < array.GetLength(1); j++)
//         array[i,j] = (new Random().NextDouble()*2-1)*a;
// }
// }
// void PrintArray(double[,] array)
// {
//     for (int i =0;i<array.GetLength(0);i++)
//         {
//         for (int j =0;j<array.GetLength(1);j++)
//             Console.Write($"{Math.Round(array[i,j],3),10}   ");
//         System.Console.WriteLine();
//         }
// }
void FillArrayInt(int [,] array, int a)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = new Random().Next(-a,a);
}
}
void PrintArrayInt(int [,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],10}   ");
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
// task58 : УМНОЖЕНИЕ МАТРИЦ.
// void SortArrayRows(double[,] array)
// {
// // int n = array.GetLength(0);
// int m = array.GetLength(1);
// for (int k = 0; k < array.GetLength(0) ; k++)
// {
// for (int i = 0; i < m ; i++)
// {
//     for (int j = 0; j < m-1-i; j++)
//     {
//     if(array[k,j]>array[k,j+1]) (array[k,j],array[k,j+1])=(array[k,j+1],array[k,j]);
//   }}}}
int [,] MatrixMultiplicationInt (int [,] A, int [,] B)
{
    int [,] C = new int [ A.GetLength(0), B.GetLength(1)];
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
       C [i,j] = 0;
       for (int k = 0; k < A.GetLength(1); k++)
        {
          C [i,j] += A[i,k] * B[k,j];  
        }
    }
}
return C;
}
Console.Clear();
System.Console.WriteLine("Задайте размеры первой матрицы");
System.Console.Write("Введите количество строк - > ");
int rows1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов - > ");
int cols1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение диапазона для генерации случайных чисел первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
int [,] A = new int [rows1,cols1];
System.Console.WriteLine("Задайте размеры второй матрицы");
System.Console.Write("Введите количество столбцов - > ");
int cols2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение диапазона для генерации случайных чисел второй матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
int [,] B = new int [cols1,cols2];
FillArrayInt(A, a);
FillArrayInt(B, b);
System.Console.WriteLine("ПЕРВАЯ МАТРИЦА");
PrintArrayInt(A);
System.Console.WriteLine("ВТОРАЯ МАТРИЦА");
PrintArrayInt(B); 
System.Console.WriteLine("ИХ ПРОИЗВЕДЕНИЕ :");
int [,] C = MatrixMultiplicationInt (A,B);
PrintArrayInt(C);