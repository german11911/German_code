// ввести целое N
System.Console.Write("Введите положительное целое число - > ");
int n = int.Parse(System.Console.ReadLine()!);
int m = n%10;
int mm = (n/10);
mm =mm%10;
Console.Write(n);
Console.Write(" ");
if(mm==1 || m ==0 || m>=5){
    Console.WriteLine("программистов");
   }
else {if(m==1)Console.WriteLine("программист");
    else Console.WriteLine("программиста");}