using Xunit;
namespace LeapYear
{
  public class LeapYearTest
  {
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      LeapYearExample testLeapYear = new LeapYearExample();
      Assert.Equal(true, testLeapYear.IsLeapYear(2012));
    }
    [Fact]
    public void IsLeapYear_ForMultiplesOfFourHundred_true()
    {
      LeapYearExample testLeapYear = new LeapYearExample();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
    [Fact]
    public void IsLeapYear_ForMultiplesOfOneHundred_false()
    {
      LeapYearExample testLeapYear = new LeapYearExample();
      Assert.Equal(false, testLeapYear.IsLeapYear(1900));
    }
  }
}
