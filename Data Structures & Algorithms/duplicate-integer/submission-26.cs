public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 1) return false;
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            var added = set.Add(num);
            if (added == false)
            {
                return true;
            }
        }
        return false;
    }
}