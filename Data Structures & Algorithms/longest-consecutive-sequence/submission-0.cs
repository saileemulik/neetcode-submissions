public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int count = 0;
        foreach(int num in nums)
        {
            if(!set.Contains(num-1))
            {
                int len = 1;
                while(set.Contains(num+len))
                {
                    len += 1;
                }
                count = Math.Max(count, len);
            }
        }
        return count;

    }
}
