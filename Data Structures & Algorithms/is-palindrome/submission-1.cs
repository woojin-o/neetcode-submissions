public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            var leftChar = Char.ToLower(s[left]);
            var rightChar = Char.ToLower(s[right]);
            if (!Char.IsLetterOrDigit(leftChar))
            {
                left++;
                continue;
            }
            if (!Char.IsLetterOrDigit(rightChar))
            {
                right--;
                continue;
            }
            if (leftChar != rightChar) return false;
            left++;
            right--;
        }
        return true;
    }
}
