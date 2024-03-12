using leetcode;

namespace leetcodeTest;

public class leetcode_0001test
{
    [SetUp]
    public void Setup()
    {
    }


    /// <summary>
    /// 1. Two Sum
    /// Difficulty : Easy
    /// Link : https://leetcode.com/problems/two-sum/
    /// </summary>
    [Test]
    public void Test1()
    {
        var target = 9;
        var twoSum = Leetcode.TwoSum([2, 7, 11, 15], target);
        Assert.IsNotEmpty(twoSum);
    }
}