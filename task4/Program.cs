// input digit - show row form -digit to digit
Console.WriteLine("please input number");
int number = Convert.ToInt32(Console.ReadLine());
int output = number * (-1);
if (output < 0)
{
    output == output * -1;
}
while (number > output)
{
    Console.WriteLine(output);
    output++
}
