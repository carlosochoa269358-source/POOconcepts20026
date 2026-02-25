namespace POO.Banckend;

public class Date
{
    //fields
    private int _year;
    private int _month;
    private int _day;

   
    //constructores
  
    public Date()
    {
        _year = 1900;
        _month = 1;
        _day = 1;
    }

    public Date(int year, int month, int day)
    {
       Year = year;
       Month = month; 
       Day = day;
    }

    //properties

    public int Year 
    { 
        get => _year;
        set => _year = validateYear(value);
    }
    public int Month { 
        get => _month;
        set => _month = validateMonth(value);
    }
    public int Day { 
        get => _day;
        set => _day = ValidateDay(value);
    }
    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    // methods
    private int validateYear(int year)
    {
        if (year < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be a greathest than 0");
        }
        return year;
    }

     private int validateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month), "month must be between 1 and 12.");
        }
        return month;
    }
    private int ValidateDay(int day)
    {
        if (day < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(day), "Day must be a greathest than 0.");
        }

        if (day == 29 && Month == 2 && IsLeapYear(Year))
        {
            return day;
        }

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (day > daysInMonth[Month - 1])
        {
            throw new ArgumentOutOfRangeException(nameof(day), $"Day must be between 1 and {daysInMonth[Month - 1]} for month {Month}.");
        }

        return day;
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}