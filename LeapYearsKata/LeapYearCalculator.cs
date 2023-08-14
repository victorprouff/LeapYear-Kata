namespace LeapYearsKata;

public class LeapYearCalculator
{
    public static bool IsLeapYear(uint year)
    {
        if ((year % 4 == 0) && (year % 100 != 0))
        {
            return true;
        }

        return false;
    }
}