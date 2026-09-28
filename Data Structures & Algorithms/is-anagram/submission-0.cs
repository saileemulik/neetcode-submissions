public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        for(int i =0; i<s.Length; i++)
        {
            if(!dict1.ContainsKey(s[i]))
            {
                dict1[s[i]] = 0;
            }
            if(!dict2.ContainsKey(t[i]))
            {
                dict2[t[i]] = 0;
            }
            dict1[s[i]] += 1;
            dict2[t[i]] += 1;
        }
        return dict1.Count==dict2.Count && !dict1.Except(dict2).Any();

    }
}
