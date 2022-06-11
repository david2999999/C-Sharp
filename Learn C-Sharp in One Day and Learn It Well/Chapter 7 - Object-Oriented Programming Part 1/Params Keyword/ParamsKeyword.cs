namespace DefaultNamespace;

public class ParamsKeyword
{
    public static void Test()
    {
        PrintNames("Peter");
        PrintNames("Yvonne", "Jamie");
        PrintNames("Abigail", "Betty", "Carol", "David");
    }

    public void PrintNames(params string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write(names[i] + " ");
        }
        
        Console.WriteLine();
    }
}