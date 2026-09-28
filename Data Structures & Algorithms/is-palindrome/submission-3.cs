public class Solution {
    public bool IsPalindrome(string s) {
        string str="";
        foreach(char ch in s)
        {
            if(char.IsLetterOrDigit(ch))
            {
                str+= ch.ToString().ToLower();
            }  }
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return   str == new string(arr);
        }
}
