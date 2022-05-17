namespace DefaultNamespace;

public class DoWhileLoop
{
    public static void Test()
    {
        int counter = 100;
        
        do {
            Console.WriteLine("Counter = {0}", counter);
            counter++;
        } while (counter < 0);
    }
}