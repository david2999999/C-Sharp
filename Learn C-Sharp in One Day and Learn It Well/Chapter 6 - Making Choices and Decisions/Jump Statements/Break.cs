namespace DefaultNamespace;

public class Break
{
    public static void Test()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = {0}", i);

            if (i == 2) break;
        }
    }
}