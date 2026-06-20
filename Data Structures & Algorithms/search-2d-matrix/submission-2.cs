public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // int col = matrix[0].Length;
        // for(int i = 0; i < matrix.Length; i++){
        //     for(int j = 0; j < col; j++){
        //         if(matrix[i][j] == target) return true;
        //     }
        // }
        // return false;
        //binary search
        int l = 0;
        int c = matrix[0].Length;
        int r = matrix.Length * c - 1;
        while(l <= r){
            int mid = l + (r-l)/2;
            int row = mid / c;
            int col = mid % c;
            if(matrix[row][col] < target){
                l = mid + 1;
            }else if(matrix[row][col] > target){
                r = mid - 1;
            }else{
                return true;
            }
        }
        return false;
    }
}
