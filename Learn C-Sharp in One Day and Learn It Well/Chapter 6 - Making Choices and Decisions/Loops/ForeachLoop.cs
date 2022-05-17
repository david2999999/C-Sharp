namespace DefaultNamespace;

public class ForeachLoop
{
    public static void Test()
    {
        char[] message = { 'H', 'e', 'l', 'l', 'o' };

        foreach (char i in message)
        {
            Console.Write(i);
        }
    }
}