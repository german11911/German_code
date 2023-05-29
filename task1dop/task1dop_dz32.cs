// удалить вторую цифру слева 3ю цифру слева целого
System.Console.Write("Введите целое, или вещественное число - > ");
double n = double.Parse(System.Console.ReadLine()!);
double x = n;
if(n>=10){
    int l = 0;
    while(x>99){
        x/=10;
        l++;}
    int vtoraya =(int) x%10;
    int pervaya = (int) (x / 10);
  //  double rest = x - m -pervaya*10;
    while (l>0){
        pervaya*=10;
        vtoraya*=10;
        l--;}
        System.Console.WriteLine(n-vtoraya-9*pervaya);
        System.Console.WriteLine(9*pervaya);
        }
else System.Console.WriteLine("нет второй цифры в целой части");