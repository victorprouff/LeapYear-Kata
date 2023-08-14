using FluentAssertions;
using LeapYearsKata;

namespace LeapYearsKataTests;

public class LeapYearShould
{
    [Fact]
    public void ReturnTrueWhenYearIs1804()
    {
        var leapYear = new LeapYearCalculator();
        var result = leapYear.IsLeapYear(1804);

        result.Should().BeTrue();
    }

    [Fact]
    public void ReturnFalseWhenYearIs1805()
    {
        var leapYear = new LeapYearCalculator();
        var result = leapYear.IsLeapYear(1805);

        result.Should().BeFalse();
    }
}