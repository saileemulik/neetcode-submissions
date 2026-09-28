public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                dict[num] =0;
            }
            dict[num] +=1;
        }
        foreach(var item in dict)
        {
            if(item.Value>1)
            {
                return true;
            }
        }
        return false;
        
    }
}