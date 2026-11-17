public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var length = nums.Length;
        var result = new List<int>();
        for (var i = 0; i < length; i++)
        {
            for (var j = i + 1; j < length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result.Add(i);
                    result.Add(j);
                    return result.ToArray();;
                }
            }
        }
        return result.ToArray();
    }
}
