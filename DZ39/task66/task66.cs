//// Вывести сумму натуральных чисел между M и N 
int SumRowN(int m,int n)
{
    if(n == m) return m;
else return n + SumRowN(m,n-1);
}
System.Console.Write("Введите натуральное число M - > ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите натуральное число N - > ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n) (m,n) =(n,m); 
System.Console.WriteLine($"сумма чисел от {m} до {n} равна {SumRowN(m,n)}");