//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Print first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print second numder: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print third numder: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.Write("max = ");
Console.WriteLine(max);