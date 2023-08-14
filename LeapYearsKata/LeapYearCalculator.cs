namespace LeapYearsKata;

public class LeapYearCalculator
{
    public static bool IsLeapYear(uint year)
    {
        if (IsDivisibleBy4(year) && (year % 100 != 0))
        {
            return true;
        }

        return false;
    }

    private static bool IsDivisibleBy4(uint year) => (year % 4 == 0);
}