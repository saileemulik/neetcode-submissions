public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char ch in s)
        {
            if(ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if((ch == ')' || ch == ']' || ch == '}') && stack.Count>0)
            {
                char c = stack.Peek();
                if((ch == ')' && c == '(') || (ch == '}' && c == '{') || (ch == ']' && c == '['))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }
            else if(stack.Count == 0 && (ch == ')' || ch == ']' || ch == '}'))
            {
                stack.Push(ch);
            }

        }
        return stack.Count == 0;

    }
}
