// функция ввода кординат
double [] InputCoord (int n, int i){
 System.Console.WriteLine($"Введите координаты {i} точки");
 double [] A = new double [n];
 for( int j=0; j< n; j++){
    System.Console.Write($"{j+1}-я координата ->");
 A[j]= Convert.ToDouble(Console.ReadLine());
 }
return A;}
//
  System.Console.Write("Введите целое число - мерность пространста- > ");
int n = Convert.ToInt32(Console.ReadLine());
double [] A = new double [n];
double [] B = new double [n];
A = InputCoord(n,1);
B = InputCoord(n,2);
double s=0;
double x=0;
for(int i=0; i < n; i++){
x=(B[i]-A[i]);
s=s+x*x;}
System.Console.WriteLine($"расстояние между двумя точками в {n}-мерном пространстве = {Math.Sqrt(s)}");