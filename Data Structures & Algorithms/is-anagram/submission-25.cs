public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var map = new Dictionary<char, int>();
        foreach (var c in s)
        {
            var seen = map.ContainsKey(c);
            if (!seen)
            {
                map[c] = 1;
            } else
            {
                map[c] += 1;
            }
        }
        foreach(var c in t)
        {
            var isMatch = map.ContainsKey(c);
            if (!isMatch) return false;
            if (map[c] < 1) return false;
            map[c] -= 1;
        }
        return true;

    }
}
