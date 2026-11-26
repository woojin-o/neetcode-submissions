public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length < 2) return false;
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!set.Add(num)) return true;
        }
        return false;
    }
}