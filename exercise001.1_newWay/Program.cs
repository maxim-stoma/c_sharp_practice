int randomNum = new Random().Next(10, 100);

int num1 = randomNum % 10;
int num2 = randomNum / 10;
Console.Write($"У числа {randomNum} большая цифра ");
if (num1 > num2)
{
    Console.Write(num1);
}
else
{
    Console.Write(num2);
}
