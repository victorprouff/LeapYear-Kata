namespace LeapYearsKata;

public class Year
{
    public static bool IsLeap(uint year)
    {
        return IsDivisibleBy4(year) && (IsDivisibleBy100(year) is false || IsDivisibleBy400(year));
    }

    private static bool IsDivisibleBy400(uint year) => (year % 400 == 0);
    private static bool IsDivisibleBy100(uint year) => (year % 100 == 0);
    private static bool IsDivisibleBy4(uint year) => (year % 4 == 0);
}