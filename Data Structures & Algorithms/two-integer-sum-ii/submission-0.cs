public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] arr = new int[2];
        int left = 0;
        int right = numbers.Length - 1;
        while(left<right)
        {
            int sum = numbers[left] + numbers[right];
            if(sum>target)
            {
                right -= 1;
            }
            else if(sum < target)
            {
                left += 1;
            }
            else
            {
                arr[0] = left+1;
                arr[1] = right+1;
                break;
            }
        }
        return arr;
    }
}
