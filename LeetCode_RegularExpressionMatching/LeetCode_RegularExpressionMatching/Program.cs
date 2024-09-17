


using System.Text.RegularExpressions;

public class Solution
{
    public static void Main()
    {
        Console.WriteLine(IsMatch("aa", ".*"));
    }
    public static bool IsMatch(string s, string p)
    {
        string newPattern = @"^";
        foreach (char c in p)
        {
            if (c == '.')
            {
                newPattern += "[A-z]";
            }
            else
            {
                newPattern += c;
            }
        }
        newPattern += "$";
        Regex regex = new Regex(@newPattern);

        if (regex.IsMatch(s))
        {
            return true;
        }
        return false;
    }
}