Console.Clear();

bool A = true;
bool B = false;
bool C = false;

Console.WriteLine($"Первое логическое выражение не А и В равно {!A & B}");
Console.WriteLine($"Второе логическое выражение А или не В равно {A | !B}");
Console.WriteLine($"Второе логическое выражение А или не В равно {A & B | C}");

Console.ReadLine();