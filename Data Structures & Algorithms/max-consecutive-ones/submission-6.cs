public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var res = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == 0)
                continue;

            var count = 1;

            for (var j = i + 1; j < nums.Length; j++) {
                if (nums[j] != 1)
                    break;

                count += 1;
            }

            res = Math.Max(count, res);
        }

        return res;
    }
}