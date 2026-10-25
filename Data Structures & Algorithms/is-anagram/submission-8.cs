public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) 
        {
            return false;
        }
        
        var map = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                map.Add(s[i], 0);
            }
            if (!map.ContainsKey(t[i]))
            {
                map.Add(t[i], 0);
            }

            map[s[i]]++;
            map[t[i]]--;
        }

        foreach (var val in map.Values)
        {
            if (val != 0)
            {
                return false;
            }
        }

        return true;
    }
}
