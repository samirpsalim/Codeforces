using System;
using System.Text;

public class Solution
{
    public static string ProcessStr(string s)
    {
        bool startsFromBegin = true;
        StringBuilder result = new StringBuilder();

        foreach (char ch in s)
        {
            if (ch == '%')
            {
                startsFromBegin = !startsFromBegin;
            }
            else if (ch == '#')
            {
                result.Append(result.ToString());
            }
            else if (startsFromBegin)
            {
                if (ch == '*')
                {
                    if (result.Length > 0)
                        result.Length -= 1; // Remove last character
                }
                else
                {
                    result.Append(ch);
                }
            }
            else
            {
                if (ch == '*')
                {
                    if (result.Length > 0)
                        result.Remove(0, 1); // Remove first character
                }
                else
                {
                    result.Insert(0, ch);
                }
            }
        }

        if (!startsFromBegin)
        {
            // Reverse the result for final output
            var arr = result.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        return result.ToString();
    }
}
