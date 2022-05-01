Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mult = num1 % num2;
if(mult == 0) Console.WriteLine(num2 + " кратно " + num1);
else Console.WriteLine(num2 + " не кратно " + num1 + ", остаток " + mult);

Console.ReadLine();