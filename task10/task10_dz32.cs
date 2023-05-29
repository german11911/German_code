// ввести целое число, вывести 2ю цифру слева 
System.Console.Write("Введите целое число - > ");
int n = int.Parse(System.Console.ReadLine()!);
if(n>=10){
    while(n>99)
        n/=10;
    int m =n%10; 
    System.Console.WriteLine(m);
}
else System.Console.WriteLine("нет второй цифры слева");