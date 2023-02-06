// Program takes a number of quarter as input and gives a range of possible point coordinates as output

int quat = 0;
string xRange = "",
    yRange = "";

while ((quat < 1) || (quat > 4))
{
    Console.WriteLine("Add the number of quarter:");
    quat = int.Parse(Console.ReadLine());
}

if ((quat == 1) || (quat == 4))
{
    xRange = "[0;+inf)";
    if (quat == 1) yRange = xRange;
    else yRange = "(-inf;0]";
}
else
{
    xRange = "(-inf;0]";
    if (quat == 3) yRange = xRange;
    else yRange = "[0;+inf)";
}

Console.WriteLine($"The range for quater {quat} is X: {xRange}, Y: {yRange}");
