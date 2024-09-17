


public class Solution
{
    public static void Main()
    {
        Console.WriteLine(LongestPalindrome("aacabdkacaa"));
    }
    public static string LongestPalindrome(string s)
    {
        if (s.Length == 0)
        {
            return "";
        }
        List<string> stringList = new List<string>();
        List<int> intList = new List<int>();
        int highestInt = 0;
        bool isFound = false;
        for (int a = 0; a < s.Length; a++)
        {
            for (int b = s.Length - 1; b > a; b--)
            {
                for (int i = a, j = b; i < j; i++, j--)
                {
                    if (s[i] != s[j])
                    {
                        isFound = false;
                        break;
                    }
                    else
                    {
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    stringList.Add(s.Substring(a, (b + 1) - a));
                    intList.Add((b + 1) - a);
                    if (highestInt < (b + 1) - a)
                    {
                        highestInt = (b + 1) - a;
                    }
                }
            }
        }
        int counter = 0;
        foreach (int i in intList)
        {
            if (i == highestInt)
            {
                return stringList[counter];
            }
            else
            {
                counter++;
            }
        }
        return s[0].ToString();
    }
}