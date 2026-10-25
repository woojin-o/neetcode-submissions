public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // for each item in nums,
        // loop through remaining items,
        // checking if that combo adds up to target
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (target.Equals(nums[i] + nums[j]))
                {
                    return new [] {i, j};
                }
            }
        }

        return new int[] {};
    }
}
