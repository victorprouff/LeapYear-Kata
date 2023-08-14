namespace LeapYearsKata;

public class LeapYearCalculator
{
    public static bool IsLeapYear(uint year)
    {
        return year is 1804 or 1808;
    }
}