Console.WriteLine ("Введите целое число >0");
int number1=Convert.ToInt32 (Console.ReadLine ());
int number2=2;
while (number2<=number1)
{
    Console.Write (number2+",");
     number2=number2+2;
}
Console.WriteLine ();