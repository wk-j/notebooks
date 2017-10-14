

string f(int x)
{
    if (x == 0 || x == 1)
        return x.ToString();
    return f(x >> 1) + f(x & 1);
}

//Console.WriteLine(f(9));
Console.WriteLine(f(-9));