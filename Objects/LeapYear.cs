using System;


namespace LeapYear
{
  public class LeapYearExample
  {
    public bool IsLeapYear(int currentYear)
    {
      if(currentYear % 400 == 0)
      {
        Console.WriteLine("Divisible by 400");
        return true;
      }
      else if(currentYear % 100 == 0)
      {
        Console.WriteLine("Divisible By 100");
        return false;
      }
      else{
        return currentYear % 4 == 0;
      }
    }
  }
}
