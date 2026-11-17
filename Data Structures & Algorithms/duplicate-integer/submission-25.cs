public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 1) return false;
        var set = new HashSet<int>(nums);
        if (nums.Length > set.Count) return true;
        return false;
    }
}