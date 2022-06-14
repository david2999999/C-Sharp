namespace DefaultNamespace;

public class VIPMember : Member
{
    public VIPMember(string name, int memberID, int memberSince) :
        base (name, memberID, memberSince)
    {
        Console.WriteLine("Child Constructor with 3 parameters");
    }
    
	public override void CalculateAnnualFee()
	{
		annualFee = 1200;
	}
}