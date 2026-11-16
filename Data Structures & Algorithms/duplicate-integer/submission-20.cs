public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0) return false;
        var set = new HashSet<int>(nums);
        if (set.Count < nums.Length) return true;
        return false;
    }
}