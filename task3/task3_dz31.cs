// ввести 3 числа. выдать большее
System.Console.Write("Введите вещественное, или целое число 1  - > ");
double x1 = double.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите вещественное, или целое число 2  - > ");
double x2 = double.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите вещественное, или целое число 3  - > ");
double x3 = double.Parse(System.Console.ReadLine()!);
double max=x1;
if(x2 > max) max=x2;
if(x3 > max) max=x3;
System.Console.Write("максимальное число ");
System.Console.WriteLine(max);