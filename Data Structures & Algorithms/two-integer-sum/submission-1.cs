public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indices = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (indices.ContainsKey(diff)) return new [] { indices[diff], i};
            indices[nums[i]] = i;
        }

        return new int[] {};
    }
}
