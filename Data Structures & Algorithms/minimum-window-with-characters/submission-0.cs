public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();
        foreach(char ch in t)
        {
            if(!countT.ContainsKey(ch))
            {
                countT[ch] = 0;
            }
            countT[ch] +=1;
        }
        int minLen = int.MaxValue;
        int l = 0;
        int have = 0;
        int need = countT.Count;
        int[] res = { -1, -1 };
        for(int r = 0; r<s.Length; r++)
        {
            char ch = s[r];
            if(!window.ContainsKey(ch))
            {
                window[ch] = 0;
            }
            window[ch] += 1;
            if(countT.ContainsKey(ch) && window[ch] == countT[ch])
            {
                have += 1;
            }
            while(have == need)
            {
                if((r-l+1)<minLen)
                {
                    minLen = r-l+1;
                    res[0] = l;
                    res[1] = r;
                }
                char left = s[l];
                window[left] -= 1;
                if(countT.ContainsKey(left) && window[left]<countT[left])
                {
                    have -= 1;
                }
                l+=1;
            }
        }
        return minLen == int.MaxValue ? "":s.Substring(res[0], minLen);
    }
}
