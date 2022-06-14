namespace DefaultNamespace;

public abstract class MyAbstractClass
{
    private string message = "Hello C#";
    
    public void PrintMessage()
    {
        Console.WriteLine(message);
    }
    
    public abstract void PrintMessageAbstract();
}