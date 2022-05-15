Console.Clear();

bool A = true;
bool B = false;
bool C = false;

Console.WriteLine($"Первое логическое выражение А или В равно {A | B}");
Console.WriteLine($"Второе логическое выражение А и В равно {A & B}");
Console.WriteLine($"Третье логическое выражение В или С равно {B | C}");

Console.ReadLine();