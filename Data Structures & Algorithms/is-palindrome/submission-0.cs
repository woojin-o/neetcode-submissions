public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            var lc = s[left];
            var rc = s[right];
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
            lc = Char.ToLower(lc);
            rc = Char.ToLower(rc);
            if (lc != rc) return false;
            left += 1;
            right -= 1;
        }
        return true;
    }
}
