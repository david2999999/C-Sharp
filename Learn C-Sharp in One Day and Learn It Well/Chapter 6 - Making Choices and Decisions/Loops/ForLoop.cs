namespace DefaultNamespace;

public class ForLoop
{
    public static void Test()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        
        int[] myNumbers = { 10, 20, 30, 40, 50 };
        
        for (int i = 0; i < myNumbers.Length; i++)
        {
            Console.WriteLine(myNumbers[i]);
        }
    }
}