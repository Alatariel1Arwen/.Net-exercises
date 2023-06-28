Console.WriteLine("Write something: ");
string aa = Console.ReadLine();

var result = aa.ToCharArray().Reverse();

Console.WriteLine(new string(result.ToArray()));