/// Задайте массив заполненный случайными целыми числами. Найти минимальное и максимальные значения, их индексы, среднеарифметическое.
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
// поиск мин-макс значений и индексы элементов, среднеарифметическое элементов
int [] ArrayMinMax (int[] array)
{
    int [] arrayMinMax = new int [5];
    arrayMinMax[4]=0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]< arrayMinMax[1]){
         arrayMinMax[1]=array[i];
         arrayMinMax[0]=i;   
        }
        if (array[i]> arrayMinMax[3]){
         arrayMinMax[3]=array[i];
         arrayMinMax[2]=i;   
        }
        arrayMinMax[4]+=array[i];
    }
        return arrayMinMax;
}
System.Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите нижнюю границу диапазона значений массива: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите верхнюю границу диапазона значений массива: ");
int b = int.Parse(Console.ReadLine()!);
int [] array999 = new int [length];
FillArray(array999, a, b);
System.Console.WriteLine("в массиве ");
PrintArray(array999);
int [] arrayMinMax = ArrayMinMax(array999);
double srarithm = arrayMinMax[4]/Convert.ToDouble(length);
System.Console.WriteLine($"наименьший элемент массива с индексом {arrayMinMax[0]} и значением {arrayMinMax[1]}, наибольший элемент массива с индексом {arrayMinMax[2]} и значением {arrayMinMax[3]}, среднеарифметическое элементов массива равно {srarithm}");