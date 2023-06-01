// принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом
int lenthN(int n){
    int i=1;
    int m=n/10;
    while (m>0)
    {
        m/=10;
        i++;
    }
    return i;}
//Console.Clear();
System.Console.Write("Введите целое число - > ");
int n = Convert.ToInt32(Console.ReadLine());
//System.Console.Write($"В числе {n}   {lenthN(n)} разрядов");
int ln = lenthN(n);
int [] numberN = new int [lenthN(n)];
int m =n;
for(int i=0; i < ln; i++){
    numberN[i]=m%10;
    m/=10;
    Console.Write($"{numberN[i]} ");
}
bool R= true;
for (int i=0; i < ln/2; i++){
    if(numberN[i]==numberN[ln-1-i]){}
    else{
Console.WriteLine($" число {n} не является полиндромом");
R= false;
break;
    }
}
if(R) Console.WriteLine($" число {n} является полиндромом");