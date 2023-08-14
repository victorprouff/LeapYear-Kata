using FluentAssertions;
using LeapYearsKata;

namespace LeapYearsKataTests;

public class LeapYearShould
{
    [Theory]
    [InlineData(1804)]
    [InlineData(1808)]
    [InlineData(1812)]
    [InlineData(1816)]
    [InlineData(1996)]
    [InlineData(2000)]
    public void ReturnTrueWhenYearIsLeapYear(uint year)
    {
        var result = Year.IsLeap(year);

        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(1805)]
    [InlineData(1806)]
    [InlineData(1807)]
    [InlineData(1809)]
    [InlineData(1800)]
    [InlineData(1900)]
    [InlineData(2001)]
    public void ReturnFalseWhenYearIsNotLeapYear(uint year)
    {
        var result = Year.IsLeap(year);

        result.Should().BeFalse();
    }
}