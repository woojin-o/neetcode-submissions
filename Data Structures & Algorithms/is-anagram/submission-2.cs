public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var arr1 = s.ToCharArray();
        var arr2 = t.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);
        var str1 = new string(arr1);
        var str2 = new string(arr2);
        return str1 == str2;
    }
}
