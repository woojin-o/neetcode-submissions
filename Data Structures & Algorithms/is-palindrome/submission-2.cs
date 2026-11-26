public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            var lc = Char.ToLower(s[left]);
            var rc = Char.ToLower(s[right]);
            if (!Char.IsLetterOrDigit(lc))
            {
                left += 1;
                continue;
            }
            if (!Char.IsLetterOrDigit(rc))
            {
                right -= 1;
                continue;
            }
            if (lc != rc) return false;
            left += 1;
            right -= 1;
        }
        return true;
    }
}
