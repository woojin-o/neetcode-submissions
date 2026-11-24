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
            if (map.TryGetValue(letter, out var expectedOb))
            {
                if (stack.Count > 0)
                {
                    var ob = stack.Peek();
                    if (ob == expectedOb)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(letter);
            }
        }
        return stack.Count == 0;
    }
}
