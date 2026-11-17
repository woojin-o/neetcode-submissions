public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var remaining = new List<char>(t);
        foreach (char current in s)
        {
            if (!remaining.Remove(current)) return false;
        }

        return true;
    }
}
