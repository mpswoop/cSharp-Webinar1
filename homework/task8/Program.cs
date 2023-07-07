//row of even numbers
Console.WriteLine("Let's check if your number is even.");
Console.WriteLine("Please input number:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (num == 0)
{
    Console.WriteLine("0");
}
if (num > 0)
{
    while (num > i)
    {
    i == i+2;
    Console.WriteLine(i);
    }
}
else if (num < 0)
{
    while (num * -1 > i)
    {
    i == i+2;
    Console.WriteLine(i * -1);
    }
}