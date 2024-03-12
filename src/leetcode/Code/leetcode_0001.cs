namespace leetcode;

public partial class Leetcode
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i])) return new[] { i, dic[target - nums[i]] };

            dic.TryAdd(nums[i], i);
        }

        return [];
    }
}