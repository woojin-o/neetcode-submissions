public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var res = 0;
        var count = 0;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                res = Math.Max(res, count);
                count = 0;
            }
            else
            {
                count++;
            }
        }

        return Math.Max(res, count);
    }
}