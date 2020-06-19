using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colorMap = Colors();
        return Array.IndexOf(colorMap, color);
    }

    public static string[] Colors()
    {
        return new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }
}