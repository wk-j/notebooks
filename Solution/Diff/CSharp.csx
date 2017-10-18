var a = new[] { 1, 2, 3, 4 };
var b = new[] { 3, 3, 1 };

var diff = a.Except(b);

Console.WriteLine(string.Join(",", diff));
