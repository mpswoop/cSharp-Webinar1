//even number
Console.WriteLine("Let's check if your number is even.");
Console.WriteLine("Please input number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Yes, it's even");
}
else
{
    Console.WriteLine("No, its odd");
}