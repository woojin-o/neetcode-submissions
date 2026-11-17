public class Solution {
    public bool hasDuplicate(int[] nums) {
        var length = nums.Length;
        Array.Sort(nums);
        for (var i = 0; i < length - 1; i++)
        {
            if (nums[i] == nums[i+1]) return true;
        }
        return false;
    }
}