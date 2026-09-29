public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        Dictionary<char, int> dict1 = new Dictionary<char, int>();

        foreach (char ch in s1)
        {
            if (!dict1.ContainsKey(ch))
            {
                dict1[ch] = 0;
            }

            dict1[ch]++;
        }

        int k = s1.Length;
        int left = 0;

        while (left + k <= s2.Length)
        {
            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            // Create frequency map for current window
            for (int i = left; i < left + k; i++)
            {
                char ch = s2[i];

                if (!dict2.ContainsKey(ch))
                {
                    dict2[ch] = 0;
                }

                dict2[ch]++;
            }

            bool flag = true;

            // Compare dict1 with dict2
            foreach (var item in dict1)
            {
                if (!dict2.ContainsKey(item.Key) ||
                    dict2[item.Key] != item.Value)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                return true;
            }

            left++;
        }

        return false;
    }
}