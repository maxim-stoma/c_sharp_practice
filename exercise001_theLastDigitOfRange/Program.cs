﻿Console.WriteLine("Диапазон чисел от 10 до 99");
int num = new Random().Next(10, 99);
int digit1 = num / 10;
int digit2 = num % 10;

Console.WriteLine("Выбранное число: " + num + ".");
Console.WriteLine("Первая цифра выбранного числа: " + digit1 + ";");
Console.WriteLine("Вторая цифра выбранного числа: " + digit2 + ";");

if (digit1 == digit2)
    Console.WriteLine("Цифры одинаковые.");
else if (digit1 > digit2)
    Console.WriteLine(digit1 + " больше.");
else
    Console.WriteLine(digit2 + " больше.");