﻿namespace DefaultNamespace;

public class Member
{
    protected int annualFee;
    private string name;
    private int memberID;
    private int memberSince;
    
    public Member()
    {
        Console.WriteLine("Parent Constructor with no parameter");
    }

    public Member(string pName, int pMemberID, int pMemberSince)
    {
        Console.WriteLine("Parent Constructor with 3 parameters");
        name = pName;
        memberID = pMemberID;
        memberSince = pMemberSince;
    }

	public virtual void CalculateAnnualFee()
	{
		annualFee = 0;
	}

    public override string ToString()
    {
        return "\nName: " + name + "\nMember ID: " + memberID +
               "\nMember Since: " + memberSince + "\nTotal Annual Fee: " +
               annualFee;
    }
}