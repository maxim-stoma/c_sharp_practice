Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mult = num1 % num2;
if(mult == 0) Console.WriteLine(num2 + " times " + num1);
else Console.WriteLine(num2 + " is not a multiple of " + num1 + ", the remainder is " + mult);

Console.ReadLine();