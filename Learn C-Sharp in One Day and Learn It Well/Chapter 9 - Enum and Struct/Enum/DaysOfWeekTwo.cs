namespace DefaultNamespace;

public enum DaysOfWeekTwo
{
    Sun = 5, Mon = 10, Tues, Wed, Thurs, Fri, Sat
}

// Now, Sun is assigned a value of 5 and Mon is assigned 10. As we did not assign
// values for Tues to Sat, consecutive numbers after 10 will be assigned to them.
// That is Tues = 11, Wed = 12 and so on.