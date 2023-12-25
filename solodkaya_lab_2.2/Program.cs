Console.Write("Введите координаты первой вершины x1:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой вершины y1:");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй вершины x2:");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты второй вершины y2:");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты третьей вершины x3:");
int x3 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты третьей вершины у3:");
int y3 = int.Parse(Console.ReadLine());

int x4, y4;
if (x1 == x2)
{
    x4 = x3;
}
else if (x1 == x3)
{
    x4 = x2;
}
else
{
    x4 = x1;
}
if (y1 == y2)
{
    y4 = y3;
}
else if (y1 == y3)
{
    y4 = y2;
}
else
{
    y4 = y1;
}

Console.WriteLine($"Координаты четвертой вершины: ({x4}, {y4})");
    

