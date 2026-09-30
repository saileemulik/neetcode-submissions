public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> stack = new Stack<int>();
        foreach(var s in tokens)
        {
            if(s != "+" && s != "-" && s != "*" && s != "/")
            {
                int num = int.Parse(s);
                stack.Push(num);
            }
            else if((s == "+" || s == "-" || s == "*" || s == "/") && (stack.Count> 0))
            {
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                if(s == "+")
                {
                    stack.Push(num1+num2);
                }
                else if( s == "-")
                {
                    stack.Push(num1-num2);
                }
                else if(s == "*")
                {
                    stack.Push(num1*num2);
                }
                else if(s == "/")
                {
                    stack.Push(num1/num2);
                }
            }
        }
        return stack.Peek();
    }
}
