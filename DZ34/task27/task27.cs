// See https://aka.ms/new-console-template for more information
System.Console.Write("Введите вещественное число: ");
double x = double.Parse(Console.ReadLine()!);
if(x< 0) x=-x;
while (x%1>0){
    x *=10;
}
System.Console.WriteLine($"исходное {x}");