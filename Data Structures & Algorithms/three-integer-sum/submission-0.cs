public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> list = new List<List<int>>();
        
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if(nums[i]>0)
            {
                break;
            }
            if(i>0 && nums[i] == nums[i-1])
            {
                continue;
            }
            int l = i+1;
            int r = nums.Length - 1;
            while(l<r)
            {
                int sum = nums[i] + nums[r] + nums[l];
                if(sum>0)
                {
                    r-=1;

                }
                else if(sum<0)
                {
                    l+=1;
                }
                else 
                {
                    list.Add( new List<int> {nums[i], nums[l], nums[r]});
                    l+=1;
                    r-=1;
                    while(l<r && nums[l] == nums[l-1])
                    {
                        l+=1;
                    }
                }
            }
        }
        return list;
        
    }
}
