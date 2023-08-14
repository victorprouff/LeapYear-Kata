namespace LeapYearsKata;

public static class Year
{
    public static bool IsLeap(uint year) => year.IsDivisibleBy(4) && IsAtypicalLeap(year);

    private static bool IsAtypicalLeap(uint year) => year.IsDivisibleBy(100) is false || year.IsDivisibleBy(400);
}