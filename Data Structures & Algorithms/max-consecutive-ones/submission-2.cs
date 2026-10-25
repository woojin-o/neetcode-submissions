public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length, res = 0;
        for (int i = 0; i < n; i++) {
            int cnt = 0;
            for (int j = i; j < n; j++) {
                if (nums[j] == 0) break;
                cnt++;
            }
            res = Math.Max(res, cnt);
        }
        return res;
    }
}