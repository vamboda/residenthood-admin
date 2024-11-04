using System;
using System.Collections.Generic;

// This class contains the recurrence patterns for the lease payments schedule
public abstract class Pattern
{
    public int PatternType { get; set; }
}

public class DailyPattern : Pattern
{
    public DailyPattern()
    {
        PatternType = 1;
    }
    public int Interval { get; set; }
}

public class WeeklyPattern : Pattern
{
    public WeeklyPattern()
    {
        PatternType = 2;
    }
    public List<string> DaysOfTheWeek { get; set; }
    public int Interval { get; set; }
}

public class MonthlyPattern : Pattern
{
    public MonthlyPattern()
    {
        PatternType = 3;
    }
    public int DayOfMonth { get; set; }
    public int Interval { get; set; }
}

public class RelativeMonthlyPattern : Pattern
{
    public RelativeMonthlyPattern()
    {
        PatternType = 4;
    }
    public int DayOfTheWeekIndex { get; set; }
    public int DayOfTheWeek { get; set; }
    public int Interval { get; set; }
}

public class YearlyPattern : Pattern
{
    public YearlyPattern()
    {
        PatternType = 5;
    }
    public int Month { get; set; }
    public int DayOfTheMonth { get; set; }
}