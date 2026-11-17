public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var res = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var firstVal = nums[i];
            var secondVal = target - firstVal;

            var secondIndex = Array.IndexOf(nums, secondVal, i+1);
            if (secondIndex < 0) continue;
            res.Add(i);
            res.Add(secondIndex);
            return res.ToArray();
        }
        return res.ToArray();
    }
}
