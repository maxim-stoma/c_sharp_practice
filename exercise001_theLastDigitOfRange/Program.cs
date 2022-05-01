Console.WriteLine("Range of numbers from 10 to 99.");
int num = new Random().Next(10, 99);
int digit1 = num / 10;
int digit2 = num % 10;

Console.WriteLine("Chosen number is " + num + ".");
Console.WriteLine("The first digit is " + digit1 + ";");
Console.WriteLine("The second digit is " + digit2 + ";");

if (digit1 == digit2)
    Console.WriteLine("Digits are equal.");
else if (digit1 > digit2)
    Console.WriteLine(digit1 + " is greater.");
else
    Console.WriteLine(digit2 + " is greater.");