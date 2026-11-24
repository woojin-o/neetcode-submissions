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
            var isCloser = map.TryGetValue(letter, out var expectedOpener);
            if (isCloser == false)
            {
                stack.Push(letter);
                continue;
            }
            // confirm stack is not empty.
            var isEmpty = stack.Count == 0;
            if (isEmpty) return false;
            // compare the expectedOpener to the top of the stack.
            var opener = stack.Peek();
            var isMatch = opener == expectedOpener;
            if (isMatch == false) return false;
            stack.Pop();
        }
        return stack.Count == 0;
    }
}
