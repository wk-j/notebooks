
string toBin(int x)
{
    switch (x)
    {
        case 1:
        case 0:
            return x.ToString();
        default:
            return toBin(x / 2) + (x % 2).ToString();
    }
}

Console.WriteLine(toBin(5));
Console.WriteLine(toBin(4));