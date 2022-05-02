Console.Write("Введите большую сторону прямоугольника: ");
int rectA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите меньшую сторону прямоугольника: ");
int rectB = Convert.ToInt32(Console.ReadLine());

if(rectB > rectA) Console.WriteLine("И как у тебя меньшая сторона больше большей, умник?");
else
{
    Console.Write("Введите сторону квадрата: ");
    int sqar = Convert.ToInt32(Console.ReadLine());
    int countA = rectA / sqar;
    int countB = rectB / sqar;

    if (sqar > rectA) Console.WriteLine("Не получится вырезать квадрат из прямоугольника такого размера.");
    else if (sqar > rectB) Console.WriteLine("Не получится вырезать квадрат из прямоугольника такого размера.");
    else
    {
        int count = countA * countB;
        Console.WriteLine($"{count} квадратов можно вырезать из прямоугольника");
    }
}
Console.ReadLine();