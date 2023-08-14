using FluentAssertions;
using LeapYearsKata;

namespace LeapYearsKataTests;

public class LeapYearShould
{
    [Theory]
    [InlineData(1804)]
    [InlineData(1808)]
    public void ReturnTrueWhenYearIsLeapYear(uint year)
    {
        var leapYear = new LeapYearCalculator();
        var result = leapYear.IsLeapYear(year);

        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(1805)]
    [InlineData(1806)]
    public void ReturnFalseWhenYearIsNotLeapYear(uint year)
    {
        var leapYear = new LeapYearCalculator();
        var result = leapYear.IsLeapYear(year);

        result.Should().BeFalse();
    }
}