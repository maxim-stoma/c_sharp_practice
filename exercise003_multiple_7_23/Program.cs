Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mult7 = num % 7;
int mult23 = num % 23;

if (mult7 == mult23) Console.WriteLine(num + " кратно 7 и 23 одновременно");
else Console.WriteLine(num + " не кратно 7 и 23 одновременно");