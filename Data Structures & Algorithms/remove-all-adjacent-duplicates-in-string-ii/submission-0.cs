public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        Stack<(char ch, int count)> stack = new Stack<(char ch, int count)>();

        foreach (char ch in s)
        {
            if (stack.Count > 0 && stack.Peek().ch == ch)
            {
                var top = stack.Pop();
                top.count++;

                if (top.count < k)
                {
                    stack.Push(top);
                }
            }
            else
            {
                stack.Push((ch, 1));
            }
        }

        StringBuilder sb = new StringBuilder();

        foreach (var item in stack.Reverse())
        {
            sb.Append(item.ch, item.count);
        }

        return sb.ToString();
    }
}