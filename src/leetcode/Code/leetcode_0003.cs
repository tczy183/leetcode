namespace leetcode;
public partial class Leetcode
{
    //03. LongestSubstringWithoutRepeatingCharacters
    //Difficulty : Medium
    //Link : https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public static int LengthOfLongestSubstring(string s)
    {
        //给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。
        var dic = new Dictionary<char, int>();
        int max = 0;
        int left = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.TryGetValue(s[i], out int value))
            {
                left = Math.Max(left, value + 1);
                dic[s[i]] = i;
            }
            else
            {
                dic.Add(s[i], i);
            }

            max = Math.Max(max, i - left + 1);
        }

        return max;
    }
}