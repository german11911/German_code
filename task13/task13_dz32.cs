// ввести 3ю цифру слева целого
System.Console.Write("Введите целое число - > ");
int n = int.Parse(System.Console.ReadLine()!);
if(n>=100){
    while(n>999)
        n/=10;
    int m =n-(n/100)*100; 
    m =m%10;
    System.Console.WriteLine(m);
}
else System.Console.WriteLine("нет третьей цифры слева");