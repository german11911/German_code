// SВывести N натуральных чисел
string PrinRowN(int n)
{if(n == 1) return ("1");
else return ($"{n}, ")+ PrinRowN(n-1);
}
System.Console.Write("Введите натуральное число N - > ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PrinRowN(n));