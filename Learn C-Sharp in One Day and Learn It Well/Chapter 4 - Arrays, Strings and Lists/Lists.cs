namespace Learn_C_Sharp_in_One_Day_and_Learn_It_Well.Chapter_4___Arrays__Strings_and_Lists;

public class Lists
{
    public static void Test()
    {
        List<int> userAgeList = new List<int> { 11, 21, 31, 41 };
        
        Console.WriteLine(userAgeList[0]);
        
        userAgeList.Add(51);
        userAgeList.Add(61);

        foreach (var age in userAgeList)
        {
            Console.Write(age + " ");
        }
        
        Console.WriteLine();
        
        Console.WriteLine(userAgeList.Count);
        
        userAgeList.Insert(2, 51);
        
        foreach (var age in userAgeList)
        {
            Console.Write(age + " ");
        }

        Console.WriteLine();
        userAgeList.Remove(51);
        
        foreach (var age in userAgeList)
        {
            Console.Write(age + " ");
        }
        
        Console.WriteLine();
        userAgeList.RemoveAt(3);
        
        foreach (var age in userAgeList)
        {
            Console.Write(age + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine(userAgeList.Contains(51));
        
        userAgeList.Clear();
        
        foreach (var age in userAgeList)
        {
            Console.Write(age + " ");
        }
        
        Console.WriteLine();
    }
}