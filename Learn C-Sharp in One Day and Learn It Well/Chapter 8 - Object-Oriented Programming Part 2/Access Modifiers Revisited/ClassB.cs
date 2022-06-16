namespace DefaultNamespace;

public class ClassB:ClassA
{
    public void PrintMessages()
    {
        //This is ok
        Console.WriteLine(publicNum);
        
        //This is ok
        Console.WriteLine(protectedNum);
        
        //This is NOT ok
        Console.WriteLine(privateNum);
    }
}