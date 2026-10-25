public class Solution {
    public bool IsAnagram(string s, string t) {
        // check length
        // create hasmap to track frequency of letters
        // loop through string, adding letters to hashmap if they don't exist
        // increase the counter for those letters.
        // if the letter comes from s, increase by 1
        // if the letter comes from t, decrease by 1
        // if the frequency of letters from each string is equal,
        // the value at each key should be 0.
        // if there are any non-zero values in the hasmap,
        // then we know the frequency of letters is not the same,
        // and therefore not an anagram
        if (s.Length != t.Length) return false;
        var map = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i])) map.Add(s[i], 0);
            if (!map.ContainsKey(t[i])) map.Add(t[i], 0);
            map[s[i]]++;
            map[t[i]]--;
        }

        foreach (var val in map.Values)
        {
            if (val != 0) return false;
        }

        return true;
    }
}
