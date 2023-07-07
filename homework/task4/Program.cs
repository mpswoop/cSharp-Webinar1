// max of 3 numbers
// bigger number
Console.WriteLine("Please input three numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.Write("max = "); Console.WriteLine(num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.Write("max = "); Console.WriteLine(num2);
}
else if (num3 > num1 && num3 > num2)
{
    Console.Write("max = "); Console.WriteLine(num3);
}