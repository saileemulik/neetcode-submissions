public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
         int[] arr = new int[2];
        for(int i=0; i<nums.Length; i++)
        {
            int diff = target - nums[i];
            if(!dict.ContainsKey(diff))
            {
                dict[nums[i]] = i;
            }
            else
            {
        
                arr[0] = dict[diff];
                arr[1] = i;
                
            }
        }
        return arr;
    }
}
