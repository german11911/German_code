// ввести ввести целое число. Проверить, чётноё? да/нет
System.Console.Write("Введите целое число - > ");
int n = int.Parse(System.Console.ReadLine()!);
if(n<0) n=-n;
if(n%2==0) System.Console.WriteLine("Да,чётное");
else
System.Console.WriteLine("Нет, нечётное");