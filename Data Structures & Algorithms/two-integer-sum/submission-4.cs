public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // create map to keep track of visited numbers and their indices. 
        // loop through nums, and check if the value needed to get to the target has already been visited.
        // if it's already been visited, then return the index of the current number and the index stored for the visited value.
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (map.ContainsKey(diff))
            {
                return new [] {map[diff], i};
            }
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}
