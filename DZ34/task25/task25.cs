// See https://aka.ms/new-console-template for more information
Double Pow(double a, int b)
{double result = 1;
    for (int i=1; i<= b; i++)
{result *=a;}
return result;
}
System.Console.Write("Введите вещественное число (основание): ");
double a = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите натуральное число (степень): ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"{a} в степени {b} = {Pow(a,b)}");