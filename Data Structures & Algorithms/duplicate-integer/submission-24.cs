public class Solution {
    public bool hasDuplicate(int[] nums) {
        var length = nums.Length;
        var copy = nums.ToArray();
        Array.Sort(copy);
        for (var i = 0; i < length - 1; i++)
        {
            if (copy[i] == copy[i+1]) return true;
        }
        return false;
    }
}