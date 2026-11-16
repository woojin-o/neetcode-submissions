public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0) return false;
        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            for (var j = i + 1; j < nums.Length; j++)
            {
                var next = nums[j];
                if (current == next)
                {
                    return true;
                }
            }
        }

        return false;
    }
}