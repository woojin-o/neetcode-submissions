public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var length = nums.Length;
        var res = 0;

        for (int i = 0; i < length; i++)
        {
            var count = 0;
            for (int j = i; j < length; j++)
            {
                if (nums[j] == 0) break;
                count++;
            }
            res = Math.Max(res, count);
        }

        return res;
    }
}