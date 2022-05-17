namespace DefaultNamespace;

public class WhileLoop
{
    public static void Test()
    {
        int counter = 5;
        
        while (counter > 0)
        {
            Console.WriteLine("Counter = {0}", counter);
            counter = counter – 1;
        }
    }
}