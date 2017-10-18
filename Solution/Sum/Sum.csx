// https://www.facebook.com/photo.php?fbid=138014133612134&set=gm.760839004127371&type=3&theater&ifg=1

IEnumerable<long> rangeM(long plus)
{
    for (var i = 1; i <= 299 + plus; i++)
        yield return i;
}

long cal(long i, long j, long k) => (i * j * k) % (i + j + k);
var rs = rangeM(0).SelectMany(x => rangeM(x).SelectMany(y => rangeM(y + x).Select(z => cal(x, y, z))));
Console.WriteLine(string.Join(",", rs.Sum()));
