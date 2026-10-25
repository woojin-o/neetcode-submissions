public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var maxCount = 0;
        var counter = 0;

        // iterate through nums
        foreach (var num in nums)
        {
            if (num == 0)
            {
                if (counter > maxCount)
                {
                    maxCount = counter;
                }
                
                counter = 0;
            } else if (num == 1)
            {
                counter += 1;
                if (counter > maxCount)
                {
                    maxCount = counter;
                }
            }
        }
        return maxCount;
    }
}