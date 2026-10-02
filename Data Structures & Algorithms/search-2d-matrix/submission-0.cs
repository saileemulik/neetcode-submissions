public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int left =0;
        int right = m*n -1;
        while(left<=right)
        {
            int mid = (left + right)/2;
            int r = mid/n;
            int c = mid%n;
            if(matrix[r][c] == target)
            {
                return true;
            }
            else if(matrix[r][c] < target)
            {
                left = mid +1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }
}
