namespace Learn_C_Sharp_in_One_Day_and_Learn_It_Well.Chapter_5___Making_our_Program_Interactive;

public class UserInput
{
    public static void Test()
    {
        string userName = "";
        int userAge = 0;
        int currentYear = 0;
        
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        
        Console.Write("Please enter your age: ");
        userAge = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Please enter the current year: ");
        currentYear = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);
    }
}