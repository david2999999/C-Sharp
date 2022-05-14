namespace Learn_C_Sharp_in_One_Day_and_Learn_It_Well.Chapter_4___Arrays__Strings_and_Lists;

public class String
{
    public static void Test()
    {
        string message = "Hello World";
        string myName = "Hello World, " + "my name is Jamie";
        
        Console.WriteLine(message);
        Console.WriteLine(myName);
        Console.WriteLine(message.Length);
        Console.WriteLine(message.Substring(2, 5));

        string s1 = "This is Jamie";
        string s2 = "Hello";
        
        Console.WriteLine(s1.Equals("This is Jamie"));
        Console.WriteLine(s1.Equals(s2));

        string[] separator = { ", ", "; " };
        string names = "Peter, John; Andy, , David";
        string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        foreach (var substring in substrings)
        {
            Console.WriteLine(substring);
        }
    }
}