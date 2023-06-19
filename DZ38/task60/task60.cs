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
// void FillArrayInt(int [,] array, int a)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {for (int j = 0; j < array.GetLength(1); j++)
//         array[i,j] = new Random().Next(-a,a);
// }
// }
// void PrintArrayInt(int [,] array)
// {
//     for (int i =0;i<array.GetLength(0);i++)
//         {
//         for (int j =0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],10}   ");
//         System.Console.WriteLine();
//         }
// }
void SortArrayInt1(int[] array)
{
for (int k = 0; k < array.Length ; k++)
{
for (int i = 0; i < array.Length-1; i++)
{
    
    if(array[i]>array[i+1]) (array[i],array[i+1])=(array[i+1],array[i]);
  }}}

// void PrintArrayInt1(int [] array)
// {
//     for (int i =0;i<array.Length;i++)
//             Console.Write($"{array[i],3} ");
//         System.Console.WriteLine();
// }
void FillArrayDifferentInt(int [] array)
{
    int i = 0;
    while (i < array.Length)
   { 
    array[i] = new Random().Next(10,100);
for (int j = 0; j < i; j++) if(array[j] == array[i]) {i--;
break;}
    i++;
} 
}
//ЗАПОЛЕНИЕ ТРЁХМЕРНОГО МАССИВА ОДНОМЕРНЫМ
void FillArray3(int [,,]array3,int [] c)
{
    int n=0;
    for (int i = 0; i < array3.GetLength(0); i++)
    {
       for (int j = 0; j < array3.GetLength(1); j++)
       {
        for (int k = 0; k < array3.GetLength(2); k++)
        {
            array3[i,j,k] = c [n];
            n++;
        }
       } 
    }
}
//распечатка массива 3
void PrintArray3(int[,,] array3)
{
    string prArray =("");
    for (int i = 0; i < array3.GetLength(0); i++)
    {
       for (int j = 0; j < array3.GetLength(1); j++)
       {
        for (int k = 0; k < array3.GetLength(2); k++)
        {
            prArray += $"{array3[i,j,k]} ({i}, {j}, {k})  ";
        }
       } 
    }
System.Console.WriteLine(prArray);
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
// int [,] MatrixMultiplicationInt (int [,] A, int [,] B)
// {
//     int [,] C = new int [ A.GetLength(0), B.GetLength(1)];
// for (int i = 0; i < A.GetLength(0); i++)
// {
//     for (int j = 0; j < B.GetLength(1); j++)
//     {
//        C [i,j] = 0;
//        for (int k = 0; k < A.GetLength(1); k++)
//         {
//           C [i,j] += A[i,k] * B[k,j];  
//         }
//     }
// }
// return C;
// }
Console.Clear();
System.Console.WriteLine("Задайте размеры 3х-мерного массива");
System.Console.Write("Введите размер по первой координате - > ");
int size1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер по второй координате - > ");
int size2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер по третьей координате - > ");
int size3 = Convert.ToInt32(Console.ReadLine());
//необходимо случайно выбрать size1 x size2 x size3 целых двухмерных чисел
int amount = size1 * size2 * size3;
if(amount > 90) Console.WriteLine("столько двухзначных чисел мы не подберём, в массиве больше 90 ячеек");
else 
{
    int [] c = new int [amount] ;
int [,,] array3 = new int [size1 , size2 , size3];
FillArrayDifferentInt(c);
FillArray3(array3,c);
PrintArray3(array3);
//PrintArrayInt1(c);
//SortArrayInt1(c);
//PrintArrayInt1(c);
// FillArrayInt3(array3, c);
// PrintArrayInt3(array3);
}