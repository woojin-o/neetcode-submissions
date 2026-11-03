public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var res = 0;
        for (var i = 0; i < nums.Length; i++) {
            var count = 0;
            for (var j = i; j < nums.Length; j++) {
                if (nums[j] == 0) {
                    res = Math.Max(res, count);
                    count = 0;
                    break;
                }
                count++;
            }
            res = Math.Max(res, count);
        }
        return res;
    }
}