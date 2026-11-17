public class Solution {
    public bool hasDuplicate(int[] nums) {
        var length = nums.Length;
        if (length <= 1) return false;
        for (var i = 0; i < length; i++)
        {
            var current = nums[i];
            for (var j = i + 1; j < length; j++)
            {
                var next = nums[j];
                if (current == next) return true;
            }
        }
        return false;
    }
}