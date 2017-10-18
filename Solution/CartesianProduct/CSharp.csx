#r "../../packages/System.ValueTuple/lib/net461/System.ValueTuple.dll"

var a = new List<int> { 1,2,3 };
var b = new List<int> { 4,5,6 };

var rs = a.SelectMany(a => b.Select(b => (a,b)));

Console.WriteLine(string.Join(" ", rs));