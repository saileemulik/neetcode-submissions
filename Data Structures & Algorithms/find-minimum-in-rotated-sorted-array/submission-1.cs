public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;
        int left = 0;
        int right = nums.Length -1;
        while(left<right)
        {
            int mid = (left + right)/2;
            if(nums[mid]<nums[right])
            {
                // min = Math.Min(min, nums[left]);
                // left += 1;
                right = mid;
            }
            else
            {
               
               left = mid +1;
            }
        }
        return nums[left];
    }
}
