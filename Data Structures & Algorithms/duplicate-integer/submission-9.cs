public class Solution {
    public bool hasDuplicate(int[] nums) {
        // for every item,
        // compare with the remaining items to see if there is a duplicate. 
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i].Equals(nums[j])) return true;
            }
        }
        return false;
    }
}
