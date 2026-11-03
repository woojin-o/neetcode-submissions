public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var n = nums.Length;
        var res = 0;
        for (var i = 0; i < n; i++)
        {
            var count = 0;
            for (var j = i; j < n; j++)
            {
                if (nums[j] ==0) break;
                count++;
            }
            res = Math.Max(res, count);
        }
        return res;
    }
}