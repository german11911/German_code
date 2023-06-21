// функция Аккермана рекурсивный метод
    long Akkerman(long m,long n){
        if(m == 0){
            return n+1;
        }else if(m > 0 && n == 0){
            return Akkerman(m-1,1);
        }else{
            return Akkerman(m-1,Akkerman(m,n-1));
        }
    }
System.Console.Write("введите целое число m  ->");   
    long m = Convert.ToInt64(System.Console.ReadLine());
    System.Console.Write("введите целое число n  ->");   
        long n = Convert.ToInt64(System.Console.ReadLine());
System.Console.WriteLine($"функция Аккермана при m = {m} и n = {n} равна {Akkerman(m,n)}");   