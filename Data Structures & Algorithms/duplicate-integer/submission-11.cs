public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1]) return true;
        }
        return false;
    }
}
