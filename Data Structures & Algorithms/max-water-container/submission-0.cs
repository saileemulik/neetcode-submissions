public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length-1;
        int maxArea = 0;
        while(left < right)
        {
            int minHeight = Math.Min(heights[left], heights[right]);
            int width = right - left;
            int area = minHeight * width;
            maxArea = Math.Max(maxArea, area);
            if(heights[left]<heights[right])
            {
                left+=1;
            }
            else 
            {
                right -=1;
            }
        }
        return maxArea;
        
    }
}
