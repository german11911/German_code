// ввести цифру 1-7 -день недели. проверить, является ли выходным?
System.Console.Write("Введите целое число от 1 до 7 - > ");
int n = int.Parse(System.Console.ReadLine()!);
if(n==7 || n==6){
   System.Console.WriteLine("Да, это выходной");}
else {
   if(n<=5 && n>=1)
System.Console.WriteLine("Нет, это рабочий день");
else System.Console.WriteLine("нет такого дня недели!");}