public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        // from each starting position, 
        // count how many consecutive 1s there are.
        // keep track of the highest number 
        // return the highest number.
        var res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var counter = 0;
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] == 0)
                {
                    res = Math.Max(res, counter);
                    counter = 0;
                } else if (nums[j] == 1)
                {
                    counter += 1;
                    res = Math.Max(res, counter);
                }
            }
        }

        return res;
    }
}