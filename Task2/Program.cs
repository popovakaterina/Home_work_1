//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Print first number: ");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print second numder: ");
double number2 = Convert.ToInt32(Console.ReadLine());
double max = 0;
double min = 0;
if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
Console.Write ("max = ");
Console.WriteLine (max);

if (number1 < number2)
{
    min = number1;
}
else
{
    min = number2;
}
Console.Write ("min = ");
Console.WriteLine (min);