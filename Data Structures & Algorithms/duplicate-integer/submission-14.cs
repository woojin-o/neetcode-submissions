public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0)
        {
            return false;
        }
        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }

        return false;
        
    }
}