namespace DefaultNamespace;

public class ReturnValues
{
    public int[] ReturnUserInput()
    {
        int[] a = new int[3];
        
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter an integer: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer added to array.\n");
        }
        
        return a;
    }
    
    public List<int> ReturnUserInputList()
    {
        List<int> a = new List<int>();
        int input;
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter an integer: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer added to list.\n");
            a.Add(input);
        }
        
        return a;
    }
}