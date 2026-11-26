public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 1) return false;
        var map = new Dictionary<char, char>
        {
            {']', '['},
            {')','('},
            {'}','{'}
        };
        var stack = new Stack<char>();
        foreach (var p in s)
        {
            var isClose = map.TryGetValue(p, out var expected);
            if (!isClose)
            {
                stack.Push(p);
                continue;
            }
            var isEmpty = stack.Count == 0;
            if (isEmpty) return false;
            var open = stack.Pop();
            if (open != expected) return false;
        }
        return stack.Count == 0;
    }
}
