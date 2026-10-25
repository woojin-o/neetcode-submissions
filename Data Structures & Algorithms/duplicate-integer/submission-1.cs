public class Solution {
    public bool hasDuplicate(int[] nums) {
        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (current == nums[j]) return true;
            }
        }

        return false;
    }
}
