// Функция вывода на консоль массива в заданном формате
void PrintArray(string[] array)
{
   if(array[0]==""){
    Console.WriteLine("[]");
    return;
   }
   else{
    System.Console.Write("[");
    for (int i=0; i< array.Length-1; i++)
    { Console.Write($"\"{array[i]}\",");
    }
    Console.WriteLine($"\"{array[array.Length-1]}\"]");
    return;
}
}
// функция ввода массива с клавиатуры
string [] InputArray(){
string [] inputarray = new string []{""};
int i=0;
while (true){
    Console.Write("введите текcтовую строку, окончание - пустой ввод:   ");
string textin = Console.ReadLine();
if (textin !=(""))
{
    Array.Resize(ref inputarray, i+1);
    inputarray[i]= textin;
    i++;
}
else return inputarray;
}
}
// перебор элементов массива, проверка условия и формирование требуемого массива
string [] inputarray = InputArray();
string [] newarray = new string []{""};
int j = 0;
for (int i = 0; i < inputarray.Length; i++)
{
    if (inputarray[i].Length <=3)
    {
    Array.Resize(ref newarray, j+1);
    newarray[j]=inputarray[i];
    j++;
    }
}
PrintArray(inputarray);
PrintArray(newarray);