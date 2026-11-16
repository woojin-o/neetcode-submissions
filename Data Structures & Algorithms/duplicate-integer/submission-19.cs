public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Count() == 0) return false;
        var set = new HashSet<int>(nums);
        if (set.Count < nums.Count()) return true;
        return false;
    }
}