using leetcode;

namespace leetcodeTest;

public class leetcode_0003test
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// 3. LongestSubstringWithoutRepeatingCharacters
    /// Difficulty : Medium
    /// Link : https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    [Test]
    public void Test1()
    {
        var lengthOfLongestSubstring = Leetcode.LengthOfLongestSubstring("abcabcbb");
        Assert.That(lengthOfLongestSubstring, Is.EqualTo(3));
    }
}