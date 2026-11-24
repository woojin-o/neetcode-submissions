public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 1) return false;
        var map = new Dictionary<char, char>
            {
                {']', '['}, 
                {')', '('}, 
                {'}', '{'}
            };
        var stack = new Stack<char>();
        foreach(var letter in s)
        {
            if (!map.TryGetValue(letter, out var expected))
            {
                stack.Push(letter);
                continue;
            }
            if (!(stack.Count > 0)) return false;
            if (stack.Peek() != expected) return false;
            stack.Pop();
        }
        return stack.Count == 0;
    }
}
