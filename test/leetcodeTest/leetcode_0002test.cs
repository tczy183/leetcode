using System.Text;
using leetcode;

namespace leetcodeTest;

public class leetcode_0002test
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// 2. AddTwoNumbers
    /// Difficulty : Medium
    /// Link : https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    [Test]
    public void Test1()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var result = Leetcode.AddTwoNumbers(l1, l2);
        StringBuilder sb = new();
        while (result != null)
        {
            sb.Append(result.val);
            result = result.next;
        }
        Assert.That(sb.ToString(), Is.EqualTo("708"));
    }
}