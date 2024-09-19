



public class Solution
{
    public static void Main()
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb")); // 3,3,6
        Console.WriteLine(LengthOfLongestSubstring("dvdf"));
        Console.WriteLine(LengthOfLongestSubstring("ohvhjdml"));
    }
    public static int LengthOfLongestSubstring(string s)
    {
        int highestLength = 0;

        List<char> currentList = new List<char>();
        foreach (char c in s)
        {
            if (currentList.Contains(c)) // if repeating char, remove up to and including char, and re add the char
            {
                int index = currentList.IndexOf(c);
                for (int i = index; i >= 0; i--)
                {
                    currentList.RemoveAt(0);
                }
                currentList.Add(c);
            }
            else // if non repeating char
            {
                currentList.Add(c);
                if (currentList.Count > highestLength)
                {
                    highestLength = currentList.Count;
                }
            }
        }

        return highestLength;
    }
}