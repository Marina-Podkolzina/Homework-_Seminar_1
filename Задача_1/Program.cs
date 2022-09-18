Console.WriteLine("Введите число 1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"{number1}>{number2} max={number1}");
}
else
{
    Console.WriteLine($"{number2}>{number1} max={number2}");
}