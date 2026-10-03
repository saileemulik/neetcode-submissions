public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;
        int left = 0;
        int right = nums.Length -1;
        while(left<=right)
        {
            if(nums[left]<=nums[right])
            {
                min = Math.Min(min, nums[left]);
                left += 1;
            }
            else
            {
                min = Math.Min(min, nums[right]);
                right -= 1;
            }
        }
        return min;
    }
}
