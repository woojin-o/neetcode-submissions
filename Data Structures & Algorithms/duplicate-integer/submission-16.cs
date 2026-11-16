public class Solution {
    public bool hasDuplicate(int[] nums) {
        var len = nums.Length;
        if (len == 0) return false;
        Array.Sort(nums);
        for (var i = 0; i < len - 1; i++)
        {
            if (nums[i] == nums[i+1]) return true;
        }
        return false;
    }
}