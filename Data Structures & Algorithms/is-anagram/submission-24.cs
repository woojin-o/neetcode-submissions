public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var map = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (map.ContainsKey(c))
            {
                map[c] += 1;
                continue;
            }
            map[c] = 1;
        }
        foreach (var c in t)
        {
            if (!map.ContainsKey(c))
            {
                return false;
            }
            map[c] -= 1;
            if (map[c] < 0) return false;
        }
        return true;
    }
}
