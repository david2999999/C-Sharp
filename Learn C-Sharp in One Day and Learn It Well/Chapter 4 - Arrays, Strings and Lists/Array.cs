namespace Learn_C_Sharp_in_One_Day_and_Learn_It_Well.Chapter_4___Arrays__Strings_and_Lists;

public class Array
{
    public static void Test()
    {
        int[] userAge = { 21, 22, 23, 24, 25 };
        
        int[] userAge2 = new int[5];
        userAge2 = new [] {21, 22, 23, 24, 25};
        
        Console.WriteLine(userAge[0]);
        Console.WriteLine(userAge.Length);
        
        int[] source = {12, 1, 5, -2, 16, 14};
        int[] dest = {1, 2, 3, 4};
        System.Array.Copy(source, dest, 3);

        for (int i = 0; i < dest.Length; i++)
        {
            Console.Write(dest[i] + " ");
        }
        
        Console.WriteLine();
        
        System.Array.Sort(source);
        
        for (int i = 0; i < source.Length; i++)
        {
            Console.Write(source[i] + " ");
        }
        
        Console.WriteLine();

        Console.WriteLine(System.Array.IndexOf(source, -2));
        Console.WriteLine(System.Array.IndexOf(source, 100));
    }
}