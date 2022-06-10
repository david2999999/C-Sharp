namespace DefaultNamespace;

public class MyClass
{
    public static void Test()
    {
        int[] myArray = {1, 2, 3, 4, 5};
        PrintFirstElement(myArray);
        
        List<int> myList = new List<int> {1, 2, 3};
        PrintFirstListElement(myList);
    }
    
    public void PrintFirstElement(int[] a)
    {
        Console.WriteLine("The first element is {0}.\n", a[0]);
    }
    
    public void PrintFirstListElement(List<int> a)
    {
        Console.WriteLine("The first list element is {0}.\n", a[0]);
    }
}