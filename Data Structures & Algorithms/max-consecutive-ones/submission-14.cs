public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var res = 0;
        var count = 0;
        foreach (var num in nums)
        {
            count = num == 1 ? count + 1 : 0;
            res = Math.Max(res, count);
        }
        return res;
    }
}