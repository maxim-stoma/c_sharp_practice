Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.Write("Это похоже на трёхзначное число?");
}
else if (num > 999)
{
    Console.Write("Тут явно не три цифры.");
}
else
{
    int firstDigit = num / 100;
    int secondDigit = (num / 10) % 10;
    int thirdDigit = num % 10;
    int reverse = (thirdDigit * 100) + (secondDigit * 10) + firstDigit;
    Console.WriteLine($"Обратное число {reverse}");
}
Console.ReadLine();