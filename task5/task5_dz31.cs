// вывести в строчку через запятую все чётные числа от 1 до N.
System.Console.Write("Введите целое положительное число - > ");
int n = int.Parse(System.Console.ReadLine()!);
int m=2;
while(m<=n){
if(m>2) System.Console.Write(", ");    
System.Console.Write(m);
m+=2;}
System.Console.WriteLine("");