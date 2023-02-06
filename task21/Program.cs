// Find the distance between two points.

Console.WriteLine("Add X1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Add Y1:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Add X2:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Add Y2:");
double y2 = double.Parse(Console.ReadLine());

double dist;

dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

Console.WriteLine($"The distance between ({x1};{y1}) and ({x2};{y2}) is {dist}.");