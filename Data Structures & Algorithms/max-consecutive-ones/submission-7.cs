public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var count = 0;
        var res = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (num == 1)
            {
                count++;
            }
            else
            {
                res = Math.Max(res, count);
                count = 0;
            }
        }
        return Math.Max(res, count);
    }
}