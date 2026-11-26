public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            var complement = target - current;
            if (map.TryGetValue(complement, out var j))
            {
                return [j, i];
            }
            map[current] = i;
        }
        return [];
    }
}
