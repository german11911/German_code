// принимает на вход число (N) и выдаёт в строчку кубы чисел от 1 до N
int CubN(int n){
int result=n*n*n;
return result;}
//
Console.Clear();
System.Console.Write("Введите целое число - > ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<n;i++){
   System.Console.Write($"{CubN(i)}, "); 
}
System.Console.WriteLine(CubN(n));