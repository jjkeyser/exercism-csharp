using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.AddMilliseconds(1_000_000_000_000);
    }
}