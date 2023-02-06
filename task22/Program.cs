// Program takes a number as input and gives the squares of number in range [1, N] as output

int num = 0;

while (num < 1)
{
    Console.WriteLine("Add the positive number:");
    num = int.Parse(Console.ReadLine());
}

int count = 1;
int sq = 0;
while (count <= num)
{
    sq = count * count;
    Console.Write($"{sq}, ");
    count++;
}