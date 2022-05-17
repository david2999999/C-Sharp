namespace DefaultNamespace;

public class Continue
{
    public static void Test()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = {0}", i);
            
            if (i == 2) continue;
            
            Console.WriteLine("I will not be printed if i=2.\n");
        }
    }
}