// ввести 2 числа. выдать большее 
System.Console.Write("Введите вещественное, или целое число 1  - > ");
double x1 = double.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите вещественное, или целое число 2  - > ");
double x2 = double.Parse(System.Console.ReadLine()!);
if(x1 >= x2) { System.Console.Write("максимальное число ");
System.Console.WriteLine(x1);}
else { System.Console.Write("максимальное число ");
System.Console.WriteLine(x2);}