// Задайте одномерный массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами.
void FillArrayDouble(double[] array, double a)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = (new Random().NextDouble()*2-1)*a;
}
// печать массива
void PrintArrayDouble(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
//поиск мимнимального и максимального значения массива
double [] ArrayMinMax(double [] array)
{
    double [] arrayMinMax = new double[2];
    for(int i=0; i < array.Length; i++){
        if(array[i]< arrayMinMax[0]) arrayMinMax[0]= array[i];
        if(array[i]> arrayMinMax[1]) arrayMinMax[1]= array[i];
    }
    return arrayMinMax;
}
System.Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите максимальное значение диапазона: ");
double a = double.Parse(Console.ReadLine()!);
double [] array999 = new double [length];
FillArrayDouble(array999,a);
System.Console.WriteLine("в массиве ");
PrintArrayDouble(array999);
double [] arrayMinMax = ArrayMinMax(array999);
System.Console.WriteLine($"разница между минимальным {arrayMinMax[0]} и максимальным {arrayMinMax[1]} значениями равна {arrayMinMax[1]-arrayMinMax[0]}");