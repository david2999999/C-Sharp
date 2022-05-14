namespace Learn_C_Sharp_in_One_Day_and_Learn_It_Well.Chapter_4___Arrays__Strings_and_Lists;

public class Array
{
    public static void Test()
    {
        int[] userAge = { 21, 22, 23, 24, 25 };
        
        int[] userAge2 = new int[5];
        userAge2 = new [] {21, 22, 23, 24, 25};
        
        Console.WriteLine(userAge[0]);
        Console.Read();
    }
}