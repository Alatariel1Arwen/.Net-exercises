string s, revs = "";
Console.WriteLine(" Insert the text");
s = Console.ReadLine();

s = s.ToLower();

for (int i = s.Length - 1; i >= 0; i--) 
{
    revs += s[i].ToString();
}

if (revs == s)
{
    Console.WriteLine("String is Palindrome ", s, revs);
    
}
else
{
    Console.WriteLine("String is not Palindrome ", s, revs);
    
}
Console.ReadKey();
