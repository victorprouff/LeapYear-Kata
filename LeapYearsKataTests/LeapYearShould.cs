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

    [Fact]
    public void ReturnFalseWhenYearIs1805()
    {
        var leapYear = new LeapYearCalculator();
        var result = leapYear.IsLeapYear(1805);

        result.Should().BeFalse();
    }
}