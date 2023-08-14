namespace LeapYearsKata;

public static class UintExtension
{
    public static bool IsDivisibleBy(this uint year, uint modulo) => year % modulo == 0;
}