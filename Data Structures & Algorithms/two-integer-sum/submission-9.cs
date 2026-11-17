public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var res = new List<int>();
        for (var i = 0; i < nums.Length; i ++)
        {
            var firstVal = nums[i];
            var secondVal = target - firstVal;
            var secondIdx = Array.IndexOf(nums, secondVal, i+1);
            if (secondIdx < 0) continue;
            res.Add(i);
            res.Add(secondIdx);
            return res.ToArray();
        }
        return res.ToArray();
    }
}
