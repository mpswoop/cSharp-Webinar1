// check if number numberA is sqare of nuber B
Console.WriteLine("input first number");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB * numberB == numberA)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}