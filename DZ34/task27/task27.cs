        Console.Write("Введите вещественное число: ");
        decimal x = decimal.Parse(Console.ReadLine()!);
       int ndigits = 0;
        int sumdigits = 0;
        if (x < 0) x = -x;
        if (x==0){
        ndigits =1;
        sumdigits = 0;
        }        
        else {
      bool r=false;
      if(x<1) r=true;
            int i =0;
                 while (x % 1 > 0)
        {
            x *= 10;
            i++;
        }
                int y = Convert.ToInt32(x);
        while (y / 10 > 0)
        {
            ndigits++;
            sumdigits += y % 10;
            y /= 10;
        }
         ndigits++;
            sumdigits += y % 10;
      if(r) ndigits = i;
        }
        Console.WriteLine($"количество цифр {ndigits} сумма цифр {sumdigits}");
    