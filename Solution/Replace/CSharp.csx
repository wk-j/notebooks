using System.Text.RegularExpressions;

{
    //var pattern = @"(?<m>c.*?d)";

    var input = "abcxydapcdktczyd";
    var pattern = @"(?<m>c.*?d)";
    var regex = new Regex(pattern);
    var rs = regex.Replace(input, "[${m}]");

    Console.WriteLine(rs == "ab[cxyd]ap[cd]kt[czyd]");

    Console.WriteLine(rs);
}

{
    Regex regex = new Regex("(?<firstMatch>First) (?<secondMatch>Second)");
    var input = "First Second";
    string replace = regex.Replace(input, "[${secondMatch}] [${firstMatch}]");
    Console.WriteLine(replace);
}








