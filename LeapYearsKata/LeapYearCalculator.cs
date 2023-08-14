namespace LeapYearsKata;

public class LeapYearCalculator
{
    public static bool IsLeapYear(uint year)
    {
        if (IsDivisibleBy4(year) && IsDivisibleBy100(year) is false)
        {
            return true;
        }

        return false;
    }

    private static bool IsDivisibleBy100(uint year) => (year % 100 == 0);

    private static bool IsDivisibleBy4(uint year) => (year % 4 == 0);
}