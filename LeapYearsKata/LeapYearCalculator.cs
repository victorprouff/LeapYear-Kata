namespace LeapYearsKata;

public class LeapYearCalculator
{
    public static bool IsLeapYear(uint year)
    {
        return year % 4 == 0;
    }
}